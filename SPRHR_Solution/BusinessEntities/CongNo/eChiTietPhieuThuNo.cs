using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class eChiTietPhieuThuNo
    {

        public string SoPhieuThuNo { get; set; }
        public string SoHoaDon { get; set; }
        public decimal SoTien { get; set; }
        public override bool Equals(object obj)
        {
            eChiTietPhieuThuNo e;
            string strSoHoaDon;
            string strSoPhieuThuNo;
            try
            {
                e = (eChiTietPhieuThuNo)obj;
                strSoHoaDon = e.SoHoaDon;
                strSoPhieuThuNo = e.SoPhieuThuNo;
                return (SoPhieuThuNo.Equals(e.SoPhieuThuNo) && SoHoaDon.Equals(e.SoHoaDon));
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
