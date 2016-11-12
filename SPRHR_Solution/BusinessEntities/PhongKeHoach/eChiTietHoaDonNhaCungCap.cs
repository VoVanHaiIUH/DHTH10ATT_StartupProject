using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eChiTietHoaDonNhaCungCap
    {
        public string MaSp { get; set; }
        public string MaHoaDonNhaCungCap { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaMuaBenNhaCungCap { get; set; }
        public string GhiChu { get; set; }
        public string TenSp { get; set; }
        public eChiTietHoaDonNhaCungCap()
        {
            this.MaHoaDonNhaCungCap = "";
            this.MaSp = "";
            this.SoLuong = 0;
            this.GiaMuaBenNhaCungCap = 0;
            this.GhiChu = "";
            this.TenSp = "";
        }
        public eChiTietHoaDonNhaCungCap(string masp, string mahdncc, int soluong, decimal giaban, string ghichu)
        {
            this.MaHoaDonNhaCungCap = mahdncc;
            this.MaSp = masp;
            this.SoLuong = soluong;
            this.GiaMuaBenNhaCungCap = giaban;
            this.GhiChu = ghichu;
        }
        public override bool Equals(object obj)
        {
            eChiTietHoaDonNhaCungCap a = (eChiTietHoaDonNhaCungCap)obj;
            return a.MaHoaDonNhaCungCap.ToLower().Equals(a.MaHoaDonNhaCungCap.ToLower());
        }
        public override int GetHashCode()
        {
            return this.MaHoaDonNhaCungCap.ToLower().GetHashCode();
        }
    }
}
