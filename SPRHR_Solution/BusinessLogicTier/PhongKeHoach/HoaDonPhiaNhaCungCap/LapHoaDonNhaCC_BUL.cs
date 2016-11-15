using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.HoaDonPhiaNhaCungCap;

namespace BusinessLogicTier.PhongKeHoach.HoaDonPhiaNhaCungCap
{
    public class LapHoaDonNhaCC_BUL
    {
        LapHoaDonNhaCungCap_DAL z = new LapHoaDonNhaCungCap_DAL();

        public void ThemHoaDonNcc(eHoaDonNhaCungCap e)
        {
            z.InsertHoaDonNhaCungCap(e);
        }
        public List<eHoaDonNhaCungCap> GetAllHoaDonNCC()
        {
            return z.GetAllHoaDonNCC();
        }
        public List<eHoaDonNhaCungCap> GetHoaDonByMa(string mahdncc)
        {
            return z.GetHoaDonByMa(mahdncc);
        }
        public List<eChiTietHoaDonNhaCungCap> LayChitTiethoaDonNhaCC(string Ma)
        {
            return z.GetALlChiTietNCCByMaHDNCC(Ma);
        }
         public bool ThemChiTietHoaDonNCC(string mahd,string masp, int soluong, decimal  giamua,string ghichu,string tensp)
        {
            return z.InsertChiTietHoaDonNhaCungCap(mahd, masp, soluong, giamua, ghichu, tensp);
        }
        public bool XoaChiTietHoaDon(string Mahd,string Masp)
         {
             return z.DeleteChiTietHDNCC(Mahd, Masp);
         }
        public List<eHoaDonNhaCungCap> Getallhdnccnotnull()
        {
            return z.GetallhdnccNotnull();
        }
      
    }
}
