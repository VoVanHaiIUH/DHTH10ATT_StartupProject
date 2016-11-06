using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eHoaDonBanSi
    {
        public string MaHoaDonBanSi { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNhanVien { get; set; }
        public string MoTa { get; set; }
        public decimal TongTien { get; set; }
        public eHoaDonBanSi()
        {
            this.MaHoaDonBanSi = "";
            this.MaKH = "";
            this.NgayLap = DateTime.Now;
            this.MaNhanVien = "";
            this.MoTa = "";
            this.TongTien = 0;
        }
        public eHoaDonBanSi(string mahoadonbansi, string makh, DateTime ngaylap, string manhanvien, string mota, decimal tongtien)
        {
            this.MaHoaDonBanSi = mahoadonbansi;
            this.MaKH = makh;
            this.NgayLap = ngaylap;
            this.MaNhanVien = manhanvien;
            this.MoTa = mota;
            this.TongTien = tongtien;
        }
        public override bool Equals(object obj)
        {
            eHoaDonBanSi a = (eHoaDonBanSi)obj;
            return a.MaHoaDonBanSi.ToLower().Equals(a.MaHoaDonBanSi.ToLower());
        }
        public override int GetHashCode()
        {
            return this.MaHoaDonBanSi.ToLower().GetHashCode();

        }
    }
}
