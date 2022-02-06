using QuanLySinhVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public class HocPhanDAO
    {
        private static HocPhanDAO instance;
        internal static HocPhanDAO Instance
        {
            get { if (instance == null) instance = new HocPhanDAO(); return HocPhanDAO.instance; }
            private set { instance = value; }
        }

        public List<HocPhan> getListOfHocPhan()
        {
            List<HocPhan> list = new List<HocPhan>();

            string query = "SELECT * FROM dbo.HocPhan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HocPhan hocPhan = new HocPhan(item);
                list.Add(hocPhan);
            }

            return list;
        }
    }
}
