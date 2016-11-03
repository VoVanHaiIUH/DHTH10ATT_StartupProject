using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.PhieuDeNghiXuatKho;

namespace BusinessLogicTier.PhongKeHoach.PhieuDeNghiXuatKho
{
    public class LapPhieuDNXK_BUL
    {
        LapPhieuDeNghiXuatKho_DAL XK = new LapPhieuDeNghiXuatKho_DAL();
        public bool KiemTraCoKhongPDNXK(string MaPhieu)
        {
            return XK.CheckCoKhongPhieuDNXK(MaPhieu);
        }
        public int DemSoLuongPDNNK(int n)
        {
            return XK.CountSoLuongPDNXK(n);
        }
        public List<ePhieuDeNghiXuatKho> LayHetThongTinPDNXK()
        {
            return XK.GetALLPDNXK();
        }
        public List<ePhieuDeNghiXuatKho> LayThongTinPDNXKTheoMa(string MaPhieu)
        {
            return XK.GetPDNXKByMa(MaPhieu);
        }
        public List<ePhieuDeNghiXuatKho> LayHetThongTinPDNXKTheoMaNhanVien(string MaNhanVien)
        {
            return XK.GetPDNXKByMaNhanVien(MaNhanVien);
        }
        public List<ePhieuDeNghiXuatKho> LayHetThongTinPDNXKTheoMaKho(string MaKho)
        {
            return XK.GetPDNXKByMaKho(MaKho);
        }
        public List<ePhieuDeNghiXuatKho> LayHetThongTinPDNXKTheoKhachHang(string MaKhachHang)
        {
            return XK.GetPDNXKByMaKH(MaKhachHang);
        }
        public List<eChiTietPhieuDeNghiXuatKho> LayHetThongTinChiTietPDNXKTheoMaPhieu(string MaPhieu)
        {
            return XK.GetALLChitietPDNXKByMa(MaPhieu);
        }
        public void ThemPDNXK(ePhieuDeNghiXuatKho Phieu)
        {
            XK.InsertPDNXK(Phieu);
        }
        public int ThemCTPDNXK(eChiTietPhieuDeNghiXuatKho Ct)
        {
            return XK.InsertPDNXKChiTiet(Ct);
        }
        public bool XoaPDNXK(string MaPhieu)
        {
            return XK.DeLetePDNXK(MaPhieu);
        }
        public void XoaCTPDNXK(string MaPhieu, string MaSP)
        {
            XK.DeletePDNXKChiTiet(MaPhieu, MaSP);
        }
    }
}
