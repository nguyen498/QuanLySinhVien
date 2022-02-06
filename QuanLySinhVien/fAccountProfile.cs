using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;
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
    public partial class fAccountProfile : Form
    {
        private TaiKhoan currentUser;
        public TaiKhoan CurrentUser { get => currentUser; set => currentUser = value; }

        public fAccountProfile(TaiKhoan current_user)
        {
            InitializeComponent();

            this.currentUser = current_user;

            loadUserInfomations(current_user);
        }
        void loadUserInfomations(TaiKhoan tk)
        {
            txtTenDangNhap.Text = tk.TenTaiKhoan;
            txtTenHienThi.Text = tk.TenHienThi;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateTaiKhoan();
        }

        void updateTaiKhoan()
        {
            string tenTaiKhoan = txtTenDangNhap.Text;
            string tenHienThi = txtTenHienThi.Text;
            string matKhau = txtPass.Text;
            string matKhauMoi = txtNewPass.Text;
            string matKhauNhapLai = txtReEnterPass.Text;

            if (!matKhauMoi.Equals(matKhauNhapLai))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (TaiKhoanDAO.Instance.updateTaiKhoan(tenTaiKhoan, tenHienThi, matKhau, matKhauMoi))
                {
                    MessageBox.Show("Cập nhật thành công");
                    //if (updateAccount != null)
                    //    updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }

        }
    }
}
