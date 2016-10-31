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

        }
        public eChiTietHoaDonNhaCungCap(string masp, string mahdncc, int soluong, decimal giaban, string ghichu, string tensp)
        {
            this.MaHoaDonNhaCungCap = mahdncc;
            this.MaSp = masp;
            this.SoLuong = soluong;
            this.GiaMuaBenNhaCungCap = giaban;
            this.GhiChu = ghichu;
            this.TenSp = tensp;
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
