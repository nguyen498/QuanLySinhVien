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
        }

        void loadAccounts()
        {
            string connectionSTR = "Data Source=.\\FIRSTSERVER;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT * FROM dbo.TAIKHOAN";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable data = new DataTable();

            adapter.Fill(data);

            connection.Close();

            dtgvTaiKhoan.DataSource = data;

        }
    }
}
