using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.SanPhamLap;
using BusinessEntities.NhanSu;

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
    }
}
