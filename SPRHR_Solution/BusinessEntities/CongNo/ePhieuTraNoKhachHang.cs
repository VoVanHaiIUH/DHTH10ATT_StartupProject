using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.CongNo
{
    public class ePhieuTraNoKhachHang
    {
        public string SoPhieuTraNo { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayTra { get; set; }
        public string MaNhanVien { get; set; }
        public string NoiDung { get; set; }
        public List<eChiTietPhieuTraNoKhachHang> DSChiTietPhieuTraNo { get; }
        public ePhieuTraNoKhachHang()
        {

        }
        public ePhieuTraNoKhachHang(string pSoPhieuTraNo, string pMaKH, DateTime pNgayTra, string pMaNhanVien, string pNoiDung)
        {
            SoPhieuTraNo = pSoPhieuTraNo;
            MaKH = pMaKH;
            NgayTra = pNgayTra;
            MaNhanVien = pMaNhanVien;
            NoiDung = pNoiDung;
        }
        public eChiTietPhieuTraNoKhachHang ThemChiTietPhieuTraNoNCC(eChiTietPhieuTraNoKhachHang pEChiTietPhieuTraNo)
        {
            if (DSChiTietPhieuTraNo.Contains(pEChiTietPhieuTraNo))
                throw new Exception("Đã tồn tại rồi");
            DSChiTietPhieuTraNo.Add(pEChiTietPhieuTraNo);
            return pEChiTietPhieuTraNo;
        }
        public void XoaChiTietPhieuTraNoNCC(eChiTietPhieuTraNoKhachHang pEChiTietPhieuTraNo)
        {
            DSChiTietPhieuTraNo.Remove(pEChiTietPhieuTraNo);
        }
    }
}
