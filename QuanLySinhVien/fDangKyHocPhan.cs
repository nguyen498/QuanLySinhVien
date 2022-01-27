using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fDangKyHocPhan : Form
    {
        public fDangKyHocPhan()
        {
            InitializeComponent();

            loadMonHocs();
        }

        void loadMonHocs()
        {
            string query = "SELECT * FROM dbo.MONHOC";

            dtgvDKHP.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void thôngTinCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
    }
}
