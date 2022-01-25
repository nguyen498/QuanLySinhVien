using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadAccounts();

            loadSinhViens();
        }

        void loadAccounts()
        {
            //string query = "SELECT TENTAIKHOAN FROM dbo.TAIKHOAN";

            string query = "EXEC dbo.USP_GetAccountByUserName @TENTAIKHOAN";
            
            DataProvider provider = new DataProvider();

            dtgvTaiKhoan.DataSource = provider.ExecuteQuery(query, new object[] { "K9" });
        }

        void loadSinhViens()
        {
            string query = "SELECT * FROM dbo.SINHVIEN";

            DataProvider provider = new DataProvider();

            dtgvSinhVien.DataSource = provider.ExecuteQuery(query);
        }
    }
}
