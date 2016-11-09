using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuTraNoKhachHang
    {

        public string SoPhieuTraNo { get; set; }
        public string MaSoCNKH { get; set; }
        public decimal SoTien { get; set; }
        public string GhiChu { get; set; }
        public eChiTietPhieuTraNoKhachHang()
        {

        }
        public eChiTietPhieuTraNoKhachHang(string pSoPhieuTraNo, string pMaSoCNKH, decimal pSoTien, string pGhiChu)
        {
            SoPhieuTraNo = pSoPhieuTraNo;
            MaSoCNKH = pMaSoCNKH;
            SoTien = pSoTien;
            GhiChu = pGhiChu;
        }
    }
}
