using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class ePhieuTraNo
    {
        public string SoPhieuTraNo
        {
            get
            {
                return SoPhieuTraNo;
            }
            set
            {
                if (value == null)
                    throw new Exception("Số phiếu không thể null");
                SoPhieuTraNo = value;
            }
        }
        public decimal TongTien
        {
            get
            {
                return TongTien;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Tổng tiền phải là số dương");
                TongTien = value;
            }
        }
        public DateTime ThoiGian
        {
            get
            {
                return ThoiGian;
            }
            set
            {
                ThoiGian = value;
            }
            
        }
        public List<eChiTietPhieuTraNo> DSChiTietPhieuTraNo
        {
            get
            {
                return DSChiTietPhieuTraNo;
            }
            set
            {
                DSChiTietPhieuTraNo = value;/////
            }
        }
        public override bool Equals(object obj)
        {
            ePhieuTraNo e;
            string ma;
            try
            {
                e = (ePhieuTraNo)obj;
                ma = e.SoPhieuTraNo;
                return SoPhieuTraNo.Equals(e.SoPhieuTraNo);
            }
            catch
            {
                throw new Exception("Không thể so sánh 2 đối tượng khác nhau");
            }
        }
        public override int GetHashCode()
        {
            return SoPhieuTraNo.GetHashCode();
        }

        public bool ThemChiTietPhieuTraNo(eChiTietPhieuTraNo ePTN)
        {
            if (DSChiTietPhieuTraNo.Contains(ePTN))
                throw new Exception("Đã tồn tại phiếu này rồi");
            DSChiTietPhieuTraNo.Add(ePTN);
            return true;
        }
        public int SoLuongChiTietPhieuThuNo()
        {
            return DSChiTietPhieuTraNo.Count;
        }
    }
}
