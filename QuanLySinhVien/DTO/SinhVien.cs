using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySinhVien.DTO
{
    class SinhVien
    {
        private int maSinhVien;
        private string hoTen;
        private string diaChi;
        private string dienThoai;
        private int maLop;

        public SinhVien(int maSinhVien, string hoTen, string diaChi, string dienThoai, int maLop)
        {
            this.maSinhVien = maSinhVien;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.maLop = maLop;
        }

        public SinhVien(DataRow row)
        {
            this.maSinhVien = (int)row["maSinhVien"];
            this.hoTen = row["hoTen"].ToString();
            this.diaChi = row["diaChi"].ToString();
            this.dienThoai = row["dienThoai"].ToString();
            this.maLop = (int)row["maLop"];
        }

        public int MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public int MaLop { get => maLop; set => maLop = value; }
    }
}
