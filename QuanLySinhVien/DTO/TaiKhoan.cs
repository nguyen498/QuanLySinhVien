using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class TaiKhoan
    {
        private int maTaiKhoan;
        private int loaiTaiKhoan;
        private string matKhau;
        private string tenTaiKhoan;
        private string tenHienThi;

        public TaiKhoan(int maTaiKhoan, int loaiTaiKhoan, string tenTaiKhoan, string tenHienThi, string matKhau = null)
        {
            this.maTaiKhoan = maTaiKhoan;
            this.loaiTaiKhoan = loaiTaiKhoan;
            this.matKhau = matKhau;
            this.tenTaiKhoan = tenTaiKhoan;
            this.tenHienThi = tenHienThi;
        }

        public TaiKhoan(DataRow row)
        {
            this.maTaiKhoan = (int)row["maTaiKhoan"];
            this.loaiTaiKhoan = (int)row["loaiTaiKhoan"];
            this.matKhau = row["matKhau"].ToString();
            this.tenTaiKhoan = row["tenTaiKhoan"].ToString();
            this.tenHienThi = row["tenHienThi"].ToString();
        }

        public int MaTaiKhoan { get => maTaiKhoan; set => maTaiKhoan = value; }
        public int LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public string TenHienThi { get => tenHienThi; set => tenHienThi = value; }
    }
}
