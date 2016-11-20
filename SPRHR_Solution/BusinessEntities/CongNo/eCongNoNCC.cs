using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eCongNoNCC
    {
        public string MaHoaDonNCC { get; set; }
        public decimal SoTienNo { get; set; }
        public string GhiChu { get; set; }
        public DateTime NgayDaoHan { get; set; }
        public eCongNoNCC()
        {

        }
        public eCongNoNCC(string pMaHoaDonNCC, decimal pSoTienNo, string pGhiChu, DateTime pNgayDaoHan)
        {
            MaHoaDonNCC = pMaHoaDonNCC;
            SoTienNo = pSoTienNo;
            GhiChu = pGhiChu;
            NgayDaoHan = pNgayDaoHan;
        }
        public override bool Equals(object obj)
        {
            return MaHoaDonNCC.Equals(((eCongNoNCC)obj).MaHoaDonNCC);
        }
        public override int GetHashCode()
        {
            return MaHoaDonNCC.ToUpper().GetHashCode();
        }
    }
}
