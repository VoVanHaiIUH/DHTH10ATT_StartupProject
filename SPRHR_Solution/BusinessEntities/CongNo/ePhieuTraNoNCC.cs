using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class ePhieuTraNoNCC
    {
        public string SoPhieuTraNo { get; set; }
        public string MaNhaCungCap { get; set; }
        public DateTime NgayTra { get; set; }
        public string MaNhanVien { get; set; }
        public string NoiDung { get; set; }
        public List<eChiTietPhieuTraNoNCC> DSChiTietPhieuTraNo { get; }
        public ePhieuTraNoNCC()
        {
            DSChiTietPhieuTraNo = new List<eChiTietPhieuTraNoNCC>();
        }
        public ePhieuTraNoNCC(string pSoPhieuTraNo,string pMaNhaCungCap,DateTime pNgayTra,string pMaNhanVien,string pNoiDung)
        {
            SoPhieuTraNo = pSoPhieuTraNo;
            MaNhaCungCap = pMaNhaCungCap;
            NgayTra = pNgayTra;
            MaNhanVien = pMaNhanVien;
            NoiDung = pNoiDung;
            DSChiTietPhieuTraNo = new List<eChiTietPhieuTraNoNCC>();
        }
        public eChiTietPhieuTraNoNCC ThemChiTietPhieuTraNoNCC(eChiTietPhieuTraNoNCC pEChiTietPhieuTraNo)
        {
            if (DSChiTietPhieuTraNo.Contains(pEChiTietPhieuTraNo))
                throw new Exception("Đã tồn tại rồi");
            DSChiTietPhieuTraNo.Add(pEChiTietPhieuTraNo);
            return pEChiTietPhieuTraNo;
        }
        public void XoaChiTietPhieuTraNoNCC(eChiTietPhieuTraNoNCC pEChiTietPhieuTraNo)
        {
            DSChiTietPhieuTraNo.Remove(pEChiTietPhieuTraNo);
        }
    }
}
