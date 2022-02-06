using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class KhoaDAO
    {
        private static KhoaDAO instance;
        internal static KhoaDAO Instance
        {
            get { if (instance == null) instance = new KhoaDAO(); return KhoaDAO.instance; }
            private set { instance = value; }
        }

        public DataTable getKhoas()
        {
            string query = "SELECT * FROM dbo.KHOA";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Khoa> GetListOfKhoa()
        {
            List<Khoa> list = new List<Khoa>();

            string query = string.Format("SELECT * FROM dbo.Khoa");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Khoa Khoa = new Khoa(item);
                list.Add(Khoa);
            }

            return list;
        }

        public bool insertKhoa(string tenKhoa)
        {
            string query = string.Format("INSERT dbo.KHOA(TENKHOA) VALUES (N'{0}')", tenKhoa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateKhoa(int maKhoa, string tenKhoa)
        {
            string query = string.Format("UPDATE dbo.KHOA SET TENKHOA = N'{1}' WHERE MAKHOA = {0}", maKhoa, tenKhoa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteKhoa(int maKhoa)
        {
            string query = string.Format("DELETE dbo.KHOA WHERE MAKHOA = {0}", maKhoa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
