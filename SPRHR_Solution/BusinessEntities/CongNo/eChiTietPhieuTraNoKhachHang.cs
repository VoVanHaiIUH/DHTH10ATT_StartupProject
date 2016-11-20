using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuTraNoKhachHang
    {
        public DateTime NgayTra { get; set; }
        public string MaNhanVien { get; set; }
        public string MaHoaDonBanSi { get; set; }
        public string MaChiTietPhieuTraNoKH { get; set; }
        public string GhiChu { get; set; }
        public decimal SoTien { get; set; }
        public eChiTietPhieuTraNoKhachHang()
        {

        }
        public eChiTietPhieuTraNoKhachHang(string pMaChiTietPhieu,string pMaNhanVien,DateTime pNgayTra, string pMaHoaDonBanSi,string pGhiChu,decimal pSoTien )
        {
            NgayTra = pNgayTra;
            MaNhanVien = pMaNhanVien;
            MaHoaDonBanSi = pMaHoaDonBanSi;
            MaChiTietPhieuTraNoKH = pMaChiTietPhieu;
            GhiChu = pGhiChu;
            SoTien = pSoTien;
        }
        public override bool Equals(object obj)
        {
            return MaChiTietPhieuTraNoKH.Equals(((eChiTietPhieuTraNoKhachHang)obj).MaChiTietPhieuTraNoKH);
        }
        public override int GetHashCode()
        {
            return MaChiTietPhieuTraNoKH.ToUpper().GetHashCode();
        }

    }
}
