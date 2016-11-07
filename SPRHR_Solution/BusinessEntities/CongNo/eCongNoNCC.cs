using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eCongNoNCC
    {
        public string MaSoCongNoNCC { get; set; }
        public string MaHoaDonNCC { get; set; }
        public decimal SoTienNo { get; set; }
        public DateTime NgayDaoHan { get; set; }
        public string GhiChu { get; set; }
        public eCongNoNCC()
        {

        }
        public eCongNoNCC(string pMaSoCongNoNCC, string pMaHoaDonNCC, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        {
            MaSoCongNoNCC = pMaSoCongNoNCC;
            MaHoaDonNCC = pMaHoaDonNCC;
            SoTienNo = pSoTienNo;
            GhiChu = pGhiChu;
            NgayDaoHan = pNgayDaoHan;
        }
    }
}
