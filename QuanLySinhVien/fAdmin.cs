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
        BindingSource taiKhoanList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();

            dtgvTaiKhoan.DataSource = taiKhoanList;
            loadTaiKhoans();
            loadTaiKhoanBiding();
        }

        #region methods
        void loadTaiKhoans()
        {
            taiKhoanList.DataSource = TaiKhoanDAO.Instance.getTaiKhoans();
        }


        private void loadTaiKhoanBiding()
        {
            txtIDTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATAIKHOAN", true, DataSourceUpdateMode.Never));
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TENTAIKHOAN", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));
            txtMaSinhVien.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MASINHVIEN", true, DataSourceUpdateMode.Never));
        }
        #endregion




        #region Events
        private void btnViewTaiKhoan_Click(object sender, EventArgs e)
        {
            loadTaiKhoans();
        }

        #endregion

        private void btnAddTaiKhoan_Click(object sender, EventArgs e)
        {
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            int maSinhVien = Convert.ToInt32(txtMaSinhVien.Text);

            if (TaiKhoanDAO.Instance.insertTaiKhoan(tenTaiKhoan, matKhau, maSinhVien))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                loadTaiKhoans();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void btnEditTaiKhoan_Click(object sender, EventArgs e)
        {
            int maTaiKhoan = Convert.ToInt32(txtIDTaiKhoan.Text);
            string tenTaiKhoan = txtTenTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            int maSinhVien = Convert.ToInt32(txtMaSinhVien.Text);

            if (TaiKhoanDAO.Instance.updateTaiKhoan(maTaiKhoan, tenTaiKhoan, matKhau, maSinhVien))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                loadTaiKhoans();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật tài khoản");
            }
        }

        private void btnDeleteTaiKhoan_Click(object sender, EventArgs e)
        {
            int maTaiKhoan = Convert.ToInt32(txtIDTaiKhoan.Text);

            if (TaiKhoanDAO.Instance.deleteTaiKhoan(maTaiKhoan))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                loadTaiKhoans();
            }
            else
            {
                MessageBox.Show("Có lỗi khi Xóa tài khoản");
            }
        }
    }
}
