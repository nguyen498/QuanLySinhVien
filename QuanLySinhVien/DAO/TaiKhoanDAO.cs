using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;
        internal static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return TaiKhoanDAO.instance; }
            private set { instance = value; }
        }

        private TaiKhoanDAO() { }

        #region Methods
        public bool Login(string tenTaiKhoan, string matKhau)
        {
            string query = "USP_GETTAIKHOAN @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tenTaiKhoan, matKhau });

            return result.Rows.Count > 0;
        }

        public DataTable getTaiKhoans()
        {
            string query = "SELECT * FROM dbo.TAIKHOAN";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool insertTaiKhoan(string tenTaiKhoan, string matKhau, int maSinhVien)
        {
            string query = string.Format("INSERT dbo.TAIKHOAN( TENTAIKHOAN, MATKHAU, MASINHVIEN ) VALUES (N'{0}', N'{1}', {2})", tenTaiKhoan, matKhau, maSinhVien);

            int result =  DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateTaiKhoan(int maTaiKhoan, string tenTaiKhoan, string matKhau, int maSinhVien)
        {
            string query = string.Format("UPDATE dbo.TAIKHOAN SET TENTAIKHOAN = N'{1}', MATKHAU = N'{2}', MASINHVIEN = {3} WHERE MATAIKHOAN = {0}", maTaiKhoan, tenTaiKhoan, matKhau, maSinhVien);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteTaiKhoan(int maTaiKhoan)
        {
            string query = string.Format("DELETE dbo.TAIKHOAN WHERE MATAIKHOAN = {0}", maTaiKhoan);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        #endregion

    }
}
