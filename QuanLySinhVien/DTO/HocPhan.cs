using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DTO
{
    public class HocPhan
    {
        private int maHocPhan;
        private string tenHocPhan;

        public HocPhan(int maHocPhan, string tenHocPhan)
        {
            this.maHocPhan = maHocPhan;
            this.tenHocPhan = tenHocPhan;
        }

        public HocPhan(DataRow row)
        {
            this.maHocPhan = (int)row["maHocPhan"];
            this.tenHocPhan = row["tenHocPhan"].ToString();
        }

        public int MaHocPhan { get => maHocPhan; set => maHocPhan = value; }
        public string TenHocPhan { get => tenHocPhan; set => tenHocPhan = value; }
    }
}
