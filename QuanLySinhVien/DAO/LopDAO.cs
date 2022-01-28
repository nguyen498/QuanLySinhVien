using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    class LopDAO
    {
        private static LopDAO instance;
        internal static LopDAO Instance
        {
            get { if (instance == null) instance = new LopDAO(); return LopDAO.instance; }
            private set { instance = value; }
        }

        public DataTable getLops()
        {
            string query = "SELECT * FROM dbo.LOP";

            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertLop(string tenLop)
        {
            string query = string.Format("INSERT dbo.LOP( TENLOP ) VALUES (N'{0}')", tenLop);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool updateLop(int maLop, string tenLop)
        {
            string query = string.Format("UPDATE dbo.LOP SET TENLOP = N'{1}' WHERE MALOP = {0}", maLop, tenLop);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool deleteLop(int maLop)
        {
            string query = string.Format("DELETE dbo.LOP WHERE MALOP = {0}", maLop);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
