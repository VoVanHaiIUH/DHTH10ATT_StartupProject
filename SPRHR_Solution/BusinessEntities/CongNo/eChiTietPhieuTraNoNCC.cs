using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuTraNoNCC
    {
        public string SoPhieuTraNo { get; set; }
        public string MaSoCongNoNCC { get; set; }
        public decimal SoTien { get; set; }
        public string GhiChu { get; set; }
        public eChiTietPhieuTraNoNCC()
        {

        }
        public eChiTietPhieuTraNoNCC(string pSoPhieuTraNo, string pMaSoCongNoNCC, decimal pSoTien, string pGhiChu)
        {
            SoPhieuTraNo = pSoPhieuTraNo;
            MaSoCongNoNCC = pMaSoCongNoNCC;
            SoTien = pSoTien;
            GhiChu = pGhiChu;
        }
    }
}
