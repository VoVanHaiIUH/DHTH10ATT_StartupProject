using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eChiTietHoaDonBanSi
    {
        public string MaHoaDonoBanSi { get; set; }
        public int soluong { get; set; }
        public decimal GiaBanSi { get; set; }
        public string MaSP { get; set; }
        public string MaChiTietHoaDonBanSi { get; set; }
        public string GhiChu { get; set; }
        public eChiTietHoaDonBanSi()
        {

        }
        public eChiTietHoaDonBanSi(string mahoadonbansi, int soluong, decimal giabansi, string masp, string machitiet, string ghichu)
        {
            this.MaHoaDonoBanSi = mahoadonbansi;
            this.soluong = soluong;
            this.GiaBanSi = giabansi;
            this.MaSP = masp;
            this.MaChiTietHoaDonBanSi = machitiet;
            this.GhiChu = ghichu;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
