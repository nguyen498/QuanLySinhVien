using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    class Khoa
    {
        int maKhoa;
        string tenKhoa;

        public Khoa(int maKhoa, string tenKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
        }

        public Khoa(DataRow row)
        {
            this.maKhoa = (int)row["maKhoa"];
            this.tenKhoa = row["tenKhoa"].ToString();
        }

        public int MaKhoa { get => maKhoa; set => maKhoa = value; }
        public string TenKhoa { get => tenKhoa; set => tenKhoa = value; }
    }
}
