using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eTheThanhVien
    {
        public string MaThe { get; set; }
        public DateTime NgayCapThe { get; set; }
        public int SoDiem { get; set; }
        public string TenThanhVien { get; set; }
        public string DiaChi { get; set; }
        public string SoCmnd { get; set; }
        public string MaKH { get; set; }
        public eTheThanhVien()
        {
            this.MaThe = "";
            this.NgayCapThe = DateTime.Now;
            this.SoDiem = 0;
            this.TenThanhVien = "";
            this.DiaChi = "";
            this.SoCmnd = "";
            this.MaKH = "";
        }
        public eTheThanhVien(string mathe, DateTime ngaycap, int sodiem, string tenthanhvien, string diachi, string socmnd, string makh)
        {
            this.MaThe = mathe;
            this.NgayCapThe = ngaycap;
            this.SoDiem = sodiem;
            this.TenThanhVien = tenthanhvien;
            this.DiaChi = diachi;
            this.SoCmnd = socmnd;
            this.MaKH = makh;
        }
        public override bool Equals(object obj)
        {
            eTheThanhVien a = (eTheThanhVien)obj;
            return this.MaThe.ToLower().Equals(a.MaThe.ToLower());
        }
        public override int GetHashCode()
        {
            return this.MaThe.ToLower().GetHashCode();
        }
    }
}
