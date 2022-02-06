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
        public SinhVien(int maSinhVien, string hoTen, string diaChi,string dienThoai, int maLop)
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


        private int maSinhVien;

        public int MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }

        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string dienThoai;

        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }

        private int maLop;

        public int MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
    }
}
