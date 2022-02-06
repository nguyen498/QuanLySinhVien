using QuanLySinhVien.DAO;
using QuanLySinhVien.DTO;
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

        BindingSource sinhVienList = new BindingSource();

        BindingSource lopList = new BindingSource();

        BindingSource khoaList = new BindingSource();

        BindingSource monHocList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();

            dtgvTaiKhoan.DataSource = taiKhoanList;
            loadTaiKhoans();
            loadTaiKhoanBinding();

            dtgvSinhVien.DataSource = sinhVienList;
            loadSinhViens();
            loadSinhVienBinding();

            dtgvLop.DataSource = lopList;
            loadLops();
            loadLopBinding();

            dtgvKhoa.DataSource = khoaList;
            loadKhoas();
            loadKhoaBinding();

            dtgvMonHoc.DataSource = monHocList;
            loadMonHocs();
            loadMonHocBinding();
        }

        #region methods
        void loadTaiKhoans()
        {
            taiKhoanList.DataSource = TaiKhoanDAO.Instance.getTaiKhoans();
        }

        void loadSinhViens()
        {
            sinhVienList.DataSource = SinhVienDAO.Instance.getSinhViens();
        }

        void loadLops()
        {
            lopList.DataSource = LopDAO.Instance.getLops();
        }

        void loadKhoas()
        {
            khoaList.DataSource = KhoaDAO.Instance.getKhoas();
        }
        void loadMonHocs()
        {
            monHocList.DataSource = MonHocDAO.Instance.getMonHocs();
        }
        List<SinhVien> SearchSinhVienByName(string name)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSinhVienByName(name);

            return listSinhVien;
        }
        List<MonHoc> SearchMonHocByName(string name)
        {
            List<MonHoc> listMonHoc = MonHocDAO.Instance.SearchMonHocByName(name);

            return listMonHoc;
        }

        private void loadTaiKhoanBinding()
        {
            txtIDTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATAIKHOAN", true, DataSourceUpdateMode.Never));
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TENTAIKHOAN", true, DataSourceUpdateMode.Never));
            txtMatKhau.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));
            txtMaSinhVien.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MASINHVIEN", true, DataSourceUpdateMode.Never));
        }


        private void loadSinhVienBinding()
        {
            txtIDSinhVien.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "MASINHVIEN", true, DataSourceUpdateMode.Never));
            txtHoTenSinhVien.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txtDiaChiSinhVien.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txtDienThoaiSinhVien.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "DIENTHOAI", true, DataSourceUpdateMode.Never));
            txtMaLopSinhVien.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "MALOP", true, DataSourceUpdateMode.Never));
        }

        private void loadLopBinding()
        {
            txtIDLop.DataBindings.Add(new Binding("Text", dtgvLop.DataSource, "MALOP", true, DataSourceUpdateMode.Never));
            txtTenLop.DataBindings.Add(new Binding("Text", dtgvLop.DataSource, "TENLOP", true, DataSourceUpdateMode.Never));
        }

        private void loadKhoaBinding()
        {
            txtIDKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "MAKHOA", true, DataSourceUpdateMode.Never));
            txtTenKhoa.DataBindings.Add(new Binding("Text", dtgvKhoa.DataSource, "TENKHOA", true, DataSourceUpdateMode.Never));
        }
        private void loadMonHocBinding()
        {
            txtIDMonHoc.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATAIKHOAN", true, DataSourceUpdateMode.Never));
            txtTenMonHoc.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "TENTAIKHOAN", true, DataSourceUpdateMode.Never));
            txtSoTinChiMonHoc.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MATKHAU", true, DataSourceUpdateMode.Never));
            txtDonViPhuTrachMonHoc.DataBindings.Add(new Binding("Text", dtgvTaiKhoan.DataSource, "MASINHVIEN", true, DataSourceUpdateMode.Never));
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

        private void btnViewSinhVien_Click(object sender, EventArgs e)
        {
            loadSinhViens();
        }

        private void btnAddSinhVien_Click(object sender, EventArgs e)
        {
            string tenSinhVien = txtHoTenSinhVien.Text;
            string diaChi = txtDiaChiSinhVien.Text;
            string dienThoai = txtDienThoaiSinhVien.Text;
            int maLop = Convert.ToInt32(txtMaLopSinhVien.Text);

            if (SinhVienDAO.Instance.insertSinhVien(tenSinhVien, diaChi, dienThoai, maLop))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                loadSinhViens();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm tài khoản");
            }
        }

        private void btnEditSinhVien_Click(object sender, EventArgs e)
        {
            int maSinhVien = Convert.ToInt32(txtIDSinhVien.Text);
            string tenSinhVien = txtHoTenSinhVien.Text;
            string diaChi = txtDiaChiSinhVien.Text;
            string dienThoai = txtDienThoaiSinhVien.Text;
            int maLop = Convert.ToInt32(txtMaLopSinhVien.Text);

            if (SinhVienDAO.Instance.updateSinhVien(maSinhVien, tenSinhVien, diaChi, dienThoai, maLop))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                loadSinhViens();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật tài khoản");
            }
        }

        private void btnDeleteSinhVien_Click(object sender, EventArgs e)
        {
            int maSinhVien = Convert.ToInt32(txtIDSinhVien.Text);

            if (SinhVienDAO.Instance.deleteSinhVien(maSinhVien))
            {
                MessageBox.Show("Xóa sinh viên thành công");
                loadSinhViens();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa sinh viên");
            }
        }

        private void btnViewLop_Click(object sender, EventArgs e)
        {
            loadLops();
        }

        private void btnAddLop_Click(object sender, EventArgs e)
        {
            string tenLop = txtTenLop.Text;

            if (LopDAO.Instance.insertLop(tenLop))
            {
                MessageBox.Show("Thêm lớp thành công");
                loadLops();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm lớp");
            }
        }

        private void btnEditLop_Click(object sender, EventArgs e)
        {
            int maLop = Convert.ToInt32(txtIDLop.Text);
            string tenLop = txtTenLop.Text;

            if (LopDAO.Instance.updateLop(maLop,tenLop))
            {
                MessageBox.Show("Cập nhật lớp thành công");
                loadLops();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật lớp");
            }
        }

        private void btnDeleteLop_Click(object sender, EventArgs e)
        {
            int maLop = Convert.ToInt32(txtIDLop.Text);

            if (LopDAO.Instance.deleteLop(maLop))
            {
                MessageBox.Show("Xóa lớp thành công");
                loadLops();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa lớp");
            }
        }

        private void btnViewKhoa_Click(object sender, EventArgs e)
        {
            loadKhoas();
        }

        private void btnAddKhoa_Click(object sender, EventArgs e)
        {
            string tenKhoa = txtTenKhoa.Text;

            if (KhoaDAO.Instance.insertKhoa(tenKhoa))
            {
                MessageBox.Show("Thêm khoa thành công");
                loadKhoas();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm khoa");
            }
        }

        private void btnEditKhoa_Click(object sender, EventArgs e)
        {
            int maKhoa = Convert.ToInt32(txtIDKhoa.Text);
            string tenKhoa = txtTenKhoa.Text;

            if (KhoaDAO.Instance.updateKhoa(maKhoa, tenKhoa))
            {
                MessageBox.Show("Cập nhật khoa thành công");
                loadKhoas();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật khoa");
            }
        }

        private void BtnDeleteKhoa_Click(object sender, EventArgs e)
        {
            int maKhoa = Convert.ToInt32(txtIDKhoa.Text);

            if (KhoaDAO.Instance.deleteKhoa(maKhoa))
            {
                MessageBox.Show("Xóa lớp thành công");
                loadKhoas();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa lớp");
            }
        }

        private void btnSearchMonHoc_Click(object sender, EventArgs e)
        {
            monHocList.DataSource = SearchMonHocByName(txtSearchMonHoc.Text);
        }

        private void btnSearchSinhVien_Click(object sender, EventArgs e)
        {
            sinhVienList.DataSource = SearchSinhVienByName(txtSearchSinhVien.Text);
        }

        private void btnViewMonHoc_Click(object sender, EventArgs e)
        {
            loadMonHocs();
        }

        private void btnAddMonHoc_Click(object sender, EventArgs e)
        {
            string tenMonHoc = txtTenMonHoc.Text;
            int soTinChi = Convert.ToInt32(txtSoTinChiMonHoc.Text);
            int donViPhuTrach = Convert.ToInt32(txtDonViPhuTrachMonHoc.Text);

            if (MonHocDAO.Instance.insertMonHoc(tenMonHoc, soTinChi, donViPhuTrach))
            {
                MessageBox.Show("Thêm môn học thành công");
                loadMonHocs();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm môn học");
            }
        }

        private void btnEditMonHoc_Click(object sender, EventArgs e)
        {
            int maMonHoc = Convert.ToInt32(txtIDMonHoc.Text);
            string tenMonHoc = txtTenMonHoc.Text;
            int soTinChi = Convert.ToInt32(txtSoTinChiMonHoc.Text);
            int donViPhuTrach = Convert.ToInt32(txtDonViPhuTrachMonHoc.Text);

            if (MonHocDAO.Instance.updateMonHoc(maMonHoc,tenMonHoc, soTinChi,donViPhuTrach))
            {
                MessageBox.Show("Cập nhật môn học thành công");
                loadMonHocs();
            }
            else
            {
                MessageBox.Show("Có lỗi khi cập nhật môn học");
            }
        }

        private void btnDeleteMonHoc_Click(object sender, EventArgs e)
        {
            int maMonHoc = Convert.ToInt32(txtIDMonHoc.Text);

            if (MonHocDAO.Instance.deleteMonHoc(maMonHoc))
            {
                MessageBox.Show("Xóa môn học thành công");
                loadMonHocs();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa môn học");
            }
        }
    }
}
