using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class ePhieuThuNo
    {
        public string SoPhieuThuNo
        {
            get
            {
                return SoPhieuThuNo;
            }
            set
            {
                if (value == null)
                    throw new Exception("Số phiếu không thể null");
                SoPhieuThuNo = value;
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
        public List<eChiTietPhieuThuNo> DSChiTietPhieuThuNo
        {
            get
            {
                return DSChiTietPhieuThuNo;
            }
            set
            {
                DSChiTietPhieuThuNo = value;/////
            }
        }
        public override bool Equals(object obj)
        {
            ePhieuThuNo e;
            string ma;
            try
            {
                e = (ePhieuThuNo)obj;
                ma = e.SoPhieuThuNo;
                return SoPhieuThuNo.Equals(e.SoPhieuThuNo);
            }
            catch
            {
                throw new Exception("Không thể so sánh 2 đối tượng khác nhau");
            }
        }
        public override int GetHashCode()
        {
            return SoPhieuThuNo.GetHashCode();
        }

        public bool ThemChiTietPhieuThuNo(eChiTietPhieuThuNo ePTN)
        {
            if (DSChiTietPhieuThuNo.Contains(ePTN))
                throw new Exception("Đã tồn tại phiếu này rồi");
            DSChiTietPhieuThuNo.Add(ePTN);
            return true;
        }
        public int SoLuongChiTietPhieuThuNo()
        {
            return DSChiTietPhieuThuNo.Count;
        }

    }
}
