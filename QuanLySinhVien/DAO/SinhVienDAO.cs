using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class SinhVienDAO
    {
        private static SinhVienDAO instance;
        internal static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return SinhVienDAO.instance; }
            private set { instance = value; }
        }

        public DataTable getSinhViens()
        {
            string query = "SELECT * FROM dbo.SINHVIEN";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool insertSinhVien(string hoTenSinhVien, string diaChi, string dienThoai ,int maLopSinhVien)
        {
            string query = string.Format("INSERT dbo.SINHVIEN( HOTEN, DIACHI, DIENTHOAI, MALOP ) VALUES (N'{0}', N'{1}', N'{2}',{3})", hoTenSinhVien, diaChi, dienThoai, maLopSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateSinhVien(int maSinhVien, string hoTenSinhVien, string diaChi, string dienThoai, int maLopSinhVien)
        {
            string query = string.Format("UPDATE dbo.SINHVIEN SET HOTEN = N'{1}', DIACHI = N'{2}', DIENTHOAI=N'{3}', MALOP = {4} WHERE MASINHVIEN = {0}", maSinhVien, hoTenSinhVien, diaChi, dienThoai, maLopSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteTaiKhoan(int maSinhVien)
        {
            string query = string.Format("DELETE dbo.SINHVIEN WHERE MASINHVIEN = {0}", maSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
