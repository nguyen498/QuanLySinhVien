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
    public partial class fDangKyHocPhan : Form
    {

        private TaiKhoan currentUser;
        public TaiKhoan CurrentUser { get => currentUser; set => currentUser = value; }

        public fDangKyHocPhan(TaiKhoan current_user)
        {
            InitializeComponent();

            this.currentUser = current_user;

            validateLogin(current_user.LoaiTaiKhoan);

            loadListOfMonHoc();

            loadCurrentUserMonDaDangKy();
        }

        #region Methods
        void validateLogin(int loaiTaiKhoan)
        {
            adminToolStripMenuItem.Enabled = loaiTaiKhoan == 1;

            thôngTinTaiKhoanToolStripMenuItem.Text += " (" + currentUser.TenHienThi + ")";
        }

        void loadListOfMonHoc()
        {
            dtgvMonHoc.DataSource = MonHocDAO.Instance.getListOfMonHoc();
        }


        void loadCurrentUserMonDaDangKy()
        {
            int maSinhVien = currentUser.MaTaiKhoan;
            dtgvMonDaDangKy.DataSource = HocPhanDangKyDAO.Instance.getHocPhanDangKyByMaSinhVien(maSinhVien);
        }

        void loadMonHocToCB()
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.getListOfMonHoc();
            cbFilterSelect.DataSource = listMonHoc;
            cbFilterSelect.DisplayMember = "TENMONHOC";
        }
        void loadKhoaToCB()
        {
            List<Khoa> listKhoa = KhoaDAO.Instance.GetListOfKhoa();
            cbFilterSelect.DataSource = listKhoa;
            cbFilterSelect.DisplayMember = "TENKHOA";
        }

        void loadMonHocListByTenMonHocToDTGV(string tenMonHoc)
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.GetMonHocListByTenMonHoc(tenMonHoc);
            dtgvMonHoc.DataSource = listMonHoc;
        }
        void loadMonHocListByMaKhoaToDTGV(int maKhoa)
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.GetMonHocListByMaKhoa(maKhoa);
            dtgvMonHoc.DataSource = listMonHoc;
        }

        void loadListOfMonHocByTenMonHoc(string tenMonHoc)
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.SearchMonHocByName(tenMonHoc);
            dtgvMonHoc.DataSource = listMonHoc;
        }
        #endregion




        #region Events
        private void thôngTinCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(currentUser);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKyDKHP_Click(object sender, EventArgs e)
        {
            MonHoc monHocDangChon = (MonHoc)dtgvMonHoc.CurrentRow.DataBoundItem;

            int maMonHoc = monHocDangChon.MaMonHoc;
            int maSinhVien = currentUser.MaTaiKhoan;
            bool dangKyresult = HocPhanDangKyDAO.Instance.dangKyMonHoc(maMonHoc, maSinhVien);

            if (dangKyresult)
            {
                MessageBox.Show("Đăng ký thành công", "Thông Báo");
                loadCurrentUserMonDaDangKy();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại", "Thông Báo");
            }
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilter.SelectedItem.ToString().Trim())
            {
                case "Lọc theo Môn Học":
                    loadMonHocToCB();
                    break;

                case "Lọc theo Khoa":
                    loadKhoaToCB();
                    break;

                default:
                    break;
            }
        }

        private void cbFilterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            if (cbFilter.SelectedItem.ToString().Trim().Equals("Lọc theo Môn Học"))
            {
                MonHoc selected = cb.SelectedItem as MonHoc;
                string tenMonHoc = selected.TenMonHoc;
                loadMonHocListByTenMonHocToDTGV(tenMonHoc);
                return;
            }

            if (cbFilter.SelectedItem.ToString().Trim().Equals("Lọc theo Khoa"))
            {
                Khoa selected = cb.SelectedItem as Khoa;
                int maKhoa = selected.MaKhoa;
                loadMonHocListByMaKhoaToDTGV(maKhoa);
                return;
            }
        }
        private void btnHuyDangKyDKHP_Click(object sender, EventArgs e)
        {
            MonHoc monHocDangChon = (MonHoc)dtgvMonDaDangKy.CurrentRow.DataBoundItem;

            int maMonHoc = monHocDangChon.MaMonHoc;
            int maSinhVien = currentUser.MaTaiKhoan;
            bool dangKyresult = HocPhanDangKyDAO.Instance.huyDangKyMonHoc(maMonHoc, maSinhVien);

            if (dangKyresult)
            {
                MessageBox.Show("Hủy Đăng ký thành công", "Thông Báo");
                loadCurrentUserMonDaDangKy();
            }
            else
            {
                MessageBox.Show("Hủy Đăng ký thất bại", "Thông Báo");
            }
        }
        private void btnSearchMonHocClient_Click(object sender, EventArgs e)
        {
            string tenMonHoc = txtSearchMonHocClient.Text;
            loadListOfMonHocByTenMonHoc(tenMonHoc);
        }
        #endregion

    }
}
