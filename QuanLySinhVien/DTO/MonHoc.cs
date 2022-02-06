using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySinhVien.DTO
{
    public class MonHoc
    {
        private int maMonHoc;
        private string tenMonHoc;
        private int soTinChi;
        private int maKhoa;

        public MonHoc(int maMonHoc, string tenMonHoc, int soTinChi, int maKhoa)
        {
            this.maMonHoc = maMonHoc;
            this.TenMonHoc = tenMonHoc;
            this.SoTinChi = soTinChi;
            this.MaKhoa = maKhoa;
        }

        public MonHoc(DataRow row)
        {
            this.maMonHoc = (int)row["maMonHoc"];
            this.TenMonHoc = row["tenMonHoc"].ToString();
            this.SoTinChi = (int)row["soTinChi"];
            this.MaKhoa = (int)row["maKhoa"];
        }

        public int MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public int MaKhoa { get => maKhoa; set => maKhoa = value; }

    }
}

