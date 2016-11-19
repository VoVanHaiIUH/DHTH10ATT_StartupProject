using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.CongNo;
using BusinessEntities.CongNo;
using BusinessEntities.PhongKeHoach;

namespace BusinessLogicTier.CongNo
{
    public class CongNo_ALL_BUS
    {
        private CongNo_ALL_DAL CongNoDAL;
        public CongNo_ALL_BUS()
        {
            CongNoDAL = new CongNo_ALL_DAL();
        }
        public List<eKhachHang> GetListKhachHangNo()
        {
            return CongNoDAL.GetListKhachHangNo();
        }
        public List<eNhaCungCap> GetListNhaCungCapNo()
        {
            return CongNoDAL.GetListNhaCungCapNo();
        }
        public List<eCongNoNCC> GetListNoCuaNoCungCap(string pMaNhaCungCap)
        {
            return CongNoDAL.GetListNoCuaNoCungCap(pMaNhaCungCap);
        }
        public List<eCongNoKhachHang> GetListNoCuaNoKhachHang(string pMaKhachHang)
        {
            return CongNoDAL.GetListNoCuaNoKhachHang(pMaKhachHang);
        }

        public List<eChiTietPhieuTraNoNCC> GetChiTietTraNoNCC(string pMaHoaDon)
        {
            return CongNoDAL.GetListChiTietTraNoNCC(pMaHoaDon);
        }
        public List<eChiTietPhieuTraNoKhachHang> GetChiTietTraNoKH(string pMaHoaDon)
        {
            return CongNoDAL.GetListChiTietTraNoKH(pMaHoaDon);
        }
        public eChiTietPhieuTraNoNCC TraNoNCC(string pMaHoaDonNCC, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            return CongNoDAL.TraNoNCC(pMaHoaDonNCC, pMaNhanVien, pSoTien, pGhiChu);
        }
        public eChiTietPhieuTraNoKhachHang ThuNoKH(string pMaHoaDonBanSi, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            return CongNoDAL.ThuNoKH(pMaHoaDonBanSi, pMaNhanVien, pSoTien, pGhiChu);
        }
        public eCongNoNCC GhiNoNhaCungCap(string pMaHoaDonNCC, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            return CongNoDAL.GhiNoNhaCungCap(pMaHoaDonNCC, pSoTien, pNgayDaoHan, pGhiChu);
        }
        public eCongNoKhachHang GhiNoKhachHang(string pMaHoaDonBanSi, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            return CongNoDAL.GhiNoKhachHang(pMaHoaDonBanSi, pSoTien, pNgayDaoHan, pGhiChu);
        }
       
    }
}
