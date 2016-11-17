using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eCongNoKhachHang
    {
        public string MaHoaDonBanSi { get; set; }
        public decimal SoTienNo { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayDaoHan { get; set; }
        public eCongNoKhachHang()
        {

        }
        public eCongNoKhachHang(string pMaHoaDonBanSi, decimal pSoTienNo, string pGhiChu, DateTime pNgayDaoHan)
        {
            MaHoaDonBanSi = pMaHoaDonBanSi;
            SoTienNo = pSoTienNo;
            GhiChu = pGhiChu;
            NgayDaoHan = pNgayDaoHan;
        }
        public override bool Equals(object obj)
        {
            return MaHoaDonBanSi.Equals(((eCongNoKhachHang)obj).MaHoaDonBanSi);
        }
        public override int GetHashCode()
        {
            return MaHoaDonBanSi.ToUpper().GetHashCode();
        }
    }
}
