using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eHoaDonNhaCungCap
    {
        public string MaHoaDonNCC { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public decimal SoTienDaTra { get; set; }
        public eHoaDonNhaCungCap()
        {
            this.MaHoaDonNCC = "";
            this.MaNhaCungCap = "";
            this.MaNhanVien = "";
            this.NgayLap = DateTime.Now;
            this.TongTien = 0;
            this.SoTienDaTra = 0;
        }
        public eHoaDonNhaCungCap(string mahoadonncc, string manhacungcap, string manhanvien, DateTime ngaylap, decimal tongtien,decimal tiendatra)
        {
            this.MaHoaDonNCC = mahoadonncc;
            this.MaNhaCungCap = manhacungcap;
            this.MaNhanVien = manhanvien;
            this.NgayLap = ngaylap;
            this.TongTien = tongtien;
            this.SoTienDaTra = tiendatra;
        }
        public override bool Equals(object obj)
        {
            eHoaDonNhaCungCap a = (eHoaDonNhaCungCap)obj;
            return a.MaHoaDonNCC.ToLower().Equals(a.MaHoaDonNCC.ToLower());
        }
        public override int GetHashCode()
        {
            return this.MaHoaDonNCC.ToLower().GetHashCode();
        }
    }
}
