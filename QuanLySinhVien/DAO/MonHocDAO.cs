using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySinhVien.DTO;

namespace QuanLySinhVien.DAO
{
    class MonHocDAO
    {
        private static MonHocDAO instance;
        internal static MonHocDAO Instance
        {
            get { if (instance == null) instance = new MonHocDAO(); return MonHocDAO.instance; }
            private set { instance = value; }
        }

        public DataTable getMonHocs()
        {
            string query = "SELECT * FROM dbo.MONHOC";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<MonHoc> getListOfMonHoc()
        {
            List<MonHoc> list = new List<MonHoc>();

            string query = "SELECT * FROM dbo.MONHOC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonHoc MonHoc = new MonHoc(item);
                list.Add(MonHoc);
            }

            return list;
        }

        
        public List<MonHoc> GetMonHocListByTenMonHoc(string tenMonHoc)
        {
            List<MonHoc> list = new List<MonHoc>();

            string query = string.Format("SELECT * FROM dbo.MONHOC WHERE TENMONHOC = N'{0}'", tenMonHoc);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonHoc MonHoc = new MonHoc(item);
                list.Add(MonHoc);
            }

            return list;
        }

        public List<MonHoc> GetMonHocListByMaKhoa(int maKhoa)
        {
            List<MonHoc> list = new List<MonHoc>();

            string query = string.Format("SELECT * FROM dbo.MONHOC WHERE MONHOC.MAKHOA = {0}", maKhoa);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonHoc MonHoc = new MonHoc(item);
                list.Add(MonHoc);
            }

            return list;
        }


        public bool insertMonHoc(string tenMonHoc, int soTinChi, int maKhoa)
        {
            string query = string.Format("INSERT dbo.MONHOC( TENMONHOC, SOTINCHI, MAKHOA ) VALUES (N'{0}', N'{1}', N'{2}')", tenMonHoc, soTinChi, maKhoa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateMonHoc(int maMonHoc, string tenMonHoc, int soTinChi, int maKhoa)
        {
            string query = string.Format("UPDATE dbo.MONHOC SET TENMONHOC = N'{1}', SOTINCHI = N'{2}', MAKHOA=N'{3}' WHERE MAMonHoc = {0}", maMonHoc, tenMonHoc, soTinChi, maKhoa);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteMonHoc(int maMonHoc)
        {
            string query = string.Format("DELETE dbo.MONHOC WHERE MAMONHOC = {0}", maMonHoc);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<MonHoc> SearchMonHocByName(string name)
        {
            List<MonHoc> list = new List<MonHoc>();

            string query = string.Format("SELECT * FROM dbo.MONHOC WHERE dbo.fuConvertToUnsign1(TENMONHOC) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

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

