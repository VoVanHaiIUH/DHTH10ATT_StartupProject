using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eCongNoKhachHang
    {

        public string MaSoCNKH { get; set; }
        public string MaHoaDonBanSi { get; set; }
        public decimal SoTienNo { get; set; }
        public DateTime NgayDaoHan { get; set; }
        public string GhiChu { get; set; }
        public eCongNoKhachHang()
        {

        }
        public eCongNoKhachHang(string pMaSoCNKH, string pMaHoaDonBanSi, decimal pSoTienNo,DateTime pNgayDaoHan, string pGhiChu)
        {
            MaSoCNKH = pMaSoCNKH;
            MaHoaDonBanSi = pMaHoaDonBanSi;
            SoTienNo = pSoTienNo;
            NgayDaoHan = pNgayDaoHan;
            GhiChu = pGhiChu;
        }
    }
}
