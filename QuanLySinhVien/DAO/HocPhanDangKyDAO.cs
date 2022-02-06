using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class HocPhanDangKyDAO
    {
        private static HocPhanDangKyDAO instance;
        internal static HocPhanDangKyDAO Instance
        {
            get { if (instance == null) instance = new HocPhanDangKyDAO(); return HocPhanDangKyDAO.instance; }
            private set { instance = value; }
        }

        public bool dangKyMonHoc(int maMonHoc, int maSinhVien)
        {
            string query = string.Format("INSERT INTO dbo.HOCPHANDANGKY( MAMONHOC, MASINHVIEN ) VALUES ({0}, {1})", maMonHoc, maSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool huyDangKyMonHoc(int maMonHoc, int maSinhVien)
        {
            string query = string.Format("DELETE dbo.HOCPHANDANGKY WHERE MAMONHOC = {0} AND MASINHVIEN = {1}", maMonHoc, maSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<MonHoc> getHocPhanDangKyByMaSinhVien(int maSinhVien)
        {
            List<MonHoc> list = new List<MonHoc>();

            string query = string.Format("SELECT TENMONHOC, SOTINCHI, MAKHOA, dbo.MONHOC.MAMONHOC FROM dbo.HOCPHANDANGKY, dbo.MONHOC WHERE HOCPHANDANGKY.MASINHVIEN = {0} AND HOCPHANDANGKY.MAMONHOC = MONHOC.MAMONHOC", maSinhVien);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonHoc MonHoc = new MonHoc(item);
                list.Add(MonHoc);
            }

            return list;
        }
        
    }
}
