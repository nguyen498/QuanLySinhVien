using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySinhVien.DTO
{
    class MonHoc
    {
        public MonHoc(int maMonHoc, string tenMonHoc, int soTinChi, int maKhoa)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTinChi = soTinChi;
            this.maKhoa = maKhoa;
        }

        public MonHoc(DataRow row)
        {
            this.maMonHoc = (int)row["maMonHoc"];
            this.tenMonHoc = row["tenMonHoc"].ToString();
            this.soTinChi = (int)row["soTinChi"];
            this.maKhoa = (int)row["maKhoa"];
        }

        private int maMonHoc;

        public int MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }

        private string tenMonHoc;

        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { TenMonHoc = value; }
        }
        private int soTinChi;

        public int SoTinChi
        {
            get { return soTinChi; }
            set { soTinChi = value; }
        }
        private int maKhoa;

        public int MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

    }
}

