using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuTraNoNCC
    {
        public DateTime NgayTra { get; set; }
        public string MaNhanVien { get; set; }
        public string MaHoaDonNCC { get; set; }
        public string MaChiTietPhieuTraNoNCC { get; set; }
        public string GhiChu { get; set; }
        public decimal SoTien { get; set; }
        public eChiTietPhieuTraNoNCC()
        {

        }
        public eChiTietPhieuTraNoNCC(string pMaChiTietPhieu, string pMaNhanVien, DateTime pNgayTra, string pMaHoaDonNCC, string pGhiChu, decimal pSoTien)
        {
            NgayTra = pNgayTra;
            MaNhanVien = pMaNhanVien;
            MaHoaDonNCC = pMaHoaDonNCC;
            MaChiTietPhieuTraNoNCC = pMaChiTietPhieu;
            GhiChu = pGhiChu;
            SoTien = pSoTien;
        }
        public override bool Equals(object obj)
        {
            return MaChiTietPhieuTraNoNCC.Equals(((eChiTietPhieuTraNoNCC)obj).MaChiTietPhieuTraNoNCC);
        }
        public override int GetHashCode()
        {
            return MaChiTietPhieuTraNoNCC.ToUpper().GetHashCode();
        }
    }
}
