using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAO
{
    class MonHocCuaHocPhan
    {
        private static MonHocCuaHocPhan instance;
        internal static MonHocCuaHocPhan Instance
        {
            get { if (instance == null) instance = new MonHocCuaHocPhan(); return MonHocCuaHocPhan.instance; }
            private set { instance = value; }
        }

        //public bool dangKyMonHocCuaHocPhan(int maMonHoc, int maSinhVien)
        //{
        //    string query = string.Format("UPDATE dbo.HOCPHANMONHOC SET HOTEN = N'{1}', DIACHI = N'{2}', DIENTHOAI=N'{3}', MALOP = {4} WHERE MASINHVIEN = {0}", maMonHoc, maSinhVien);

        //    int result = DataProvider.Instance.ExecuteNonQuery(query);

        //    return result > 0;
        //}

    }
}

