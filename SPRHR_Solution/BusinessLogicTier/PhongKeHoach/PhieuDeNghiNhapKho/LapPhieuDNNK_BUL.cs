using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.PhieuDeNghiNhapKho;

namespace BusinessLogicTier.PhongKeHoach.PhieuDeNghiNhapKho
{
    public class LapPhieuDNNK_BUL
    {
        LapPhieuDeNghiNhapKho_DAL NK = new LapPhieuDeNghiNhapKho_DAL();
        public bool KiemTraCoKhongPDNNK(string MaPhieu)
        {
            return NK.CheckCoKhongPDNNK(MaPhieu);
        }
        public int DemSoLuongPDNNK(int n)
        {
            return NK.CountSoLuongPDNNK(n);
        }
        public List<ePhieuDeNghiNhapKho> LayHetThongTinPDNNK()
        {
            return NK.GetALLPDNNK();
        }
        public List<ePhieuDeNghiNhapKho> LayThongTinPDNNKTheoMa(string MaPhieu)
        {
            return NK.GetPDNNKByMa(MaPhieu);
        }
        public List<ePhieuDeNghiNhapKho> LayHetThongTinPDNNKTheoMaNhanVien(string MaNhanVien)
        {
            return NK.GetPDNNKByMaNhanVien(MaNhanVien);
        }
        public List<ePhieuDeNghiNhapKho> LayHetThongTinPDNNKTheoMaKho(string MaKho)
        {
            return NK.GetPDNNKByMaKho(MaKho);
        }
        public List<ePhieuDeNghiNhapKho> LayHetThongTinPDNNKTheoMaHDNhaCC(string MaHd)
        {
            return NK.GetPDNNKByMaHDNhaCungCap(MaHd);
        }
        public List<eChiTietPhieuDeNghiNhapKho> LayHetThongTinChiTietPDNNKTheoMaPhieu(string MaPhieu)
        {
            return NK.GetALLCTPDNNKByMa(MaPhieu);
        }
        public void ThemPDNNK(ePhieuDeNghiNhapKho Phieu)
        {
            NK.InsertPDNNK(Phieu);
        }
        public int ThemCTPDNNK(eChiTietPhieuDeNghiNhapKho Ct)
        {
            return NK.InsertPDNNKChiTiet(Ct);
        }
        public bool XoaPDNNK(string MaPhieu)
        {
            return NK.DeLetePDNNK(MaPhieu);
        }
        public void XoaCTPDNNK(string MaPhieu,string MaSP)
        {
            NK.DeletePDNNKChiTiet(MaPhieu, MaSP);
        }
        public string LayMaNV(string MaNV)
        {
            return NK.LayMaNhanVien(MaNV);
        }
    }
}
