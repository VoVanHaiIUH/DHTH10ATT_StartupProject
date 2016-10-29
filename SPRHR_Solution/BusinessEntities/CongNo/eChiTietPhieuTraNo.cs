using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuTraNo
    {
        public string SoPhieuTraNo { get; set; }
        public string  SoPhieuMuaHang { get; set; }
        public decimal SoTien { get; set; }
        public override bool Equals(object obj)
        {
            eChiTietPhieuTraNo e;
            string strSoPhieuMuaHang;
            string strSoPhieuTraNo;
            try
            {
                e = (eChiTietPhieuTraNo)obj;
                strSoPhieuMuaHang = e.SoPhieuMuaHang;
                strSoPhieuTraNo = e.SoPhieuTraNo;
                return (SoPhieuTraNo.Equals(e.SoPhieuTraNo) && SoPhieuMuaHang.Equals(e.SoPhieuMuaHang));
            }
            catch
            {
                throw new Exception("Không thể so sánh 2 đối tượng khác nhau");
            }
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
