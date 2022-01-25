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

            loadMonHocs();

            loadHocPhans();
        }

        void loadAccounts()
        {
            //string query = "SELECT TENTAIKHOAN FROM dbo.TAIKHOAN";

            string query = "SELECT * FROM dbo.TAIKHOAN";
            
            dtgvTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadSinhViens()
        {
            string query = "SELECT * FROM dbo.SINHVIEN";

            dtgvSinhVien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadMonHocs()
        {
            string query = "SELECT * FROM dbo.MONHOC";

            dtgvMonHoc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadHocPhans()
        {
            string query = "SELECT * FROM dbo.HOCPHAN";

            dtgvHocPhan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
