using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.SanPhamLap;
using BusinessEntities.NhanSu;
using BusinessEntities.Kho;

namespace BusinessLogicTier.PhongKeHoach.SanPham
{
    public class SanPham_BUL
    {
        SanPham_DAL z = new SanPham_DAL();

        public List<eNhaCungCap> LayNCC()
        {
            return z.GetAllNhaCC();
        }
        public List<eNhanVien> LayNV()
        {
            return z.GetAllNhanVien();
        }
        public void ThemNcc(eNhaCungCap e)
        {
            z.InsertNhaCC(e);
        }
        public List<eSanPham> LayDanhSachCanUpdate()
        {
            return z.GetAllSpCanUpdateThongTin();
        }
        public List<eSanPham> LaySanPhamTheoMa(string ma)
        {
            return z.GetAllSpByMaSP(ma);
        }
        public List<eLoaiSanPham> GetallLsp()
        {
            return z.GetalloaiSp();
        }
        public void CapNhatLaiThongTinSP(string masp, string maloaisp, string kieudang, string donvitinh, string mausac, string mota, DateTime ngaysanxuat, DateTime ngayhethan, decimal trongluong)
        {
            z.CapNhatLaiThongTinSP(masp, maloaisp, kieudang, donvitinh, mausac, mota, ngaysanxuat, ngayhethan, trongluong);
        }
        public decimal RefeshGiaBanSi(string Masp)
        {
            return z.GiaBanSi(Masp);
        }
        public bool ThemLoaiSpMoi(eLoaiSanPham loai)
        {
            return z.themLoaisp(loai);
        }
        public List<eSanPham> GetALLSpTrongHD(string Mahd)
        {
            return z.GetALLSpTrongHD(Mahd);
        }
        public List<eThongTinKho> GetALlKho()
        {
            return z.GetALlKho();
        }
        public List<eThongTinKho> GetALlKhobyMa(string maphieu)
        {
            return z.GetKhoByMa(maphieu);
        }
        public int GetSoLuongbyOneSanPham(string mahd, string masp)
        {
            return z.GetSoLuongbyOneSanPham(mahd, masp);
        }
        public int GetSoLuong1SpDaNhap(string mahoadon, string masp)
        {
            return z.GetSoLuong1SpDaNhap(mahoadon, masp);
        }
    }
}
