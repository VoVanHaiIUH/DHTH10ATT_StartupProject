using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.CuaHang;

namespace BusinessLogicTier.PhongKeHoach.CuaHang
{
    public class ThemCuaHang_BUL
    {
        ThemCuaHang_DAL Cuahang = new ThemCuaHang_DAL();
        public bool KiemTraCoKhongCuaHang(string MaCuaHang)
        {
            return Cuahang.CheckCoKhongCuaHang(MaCuaHang);
        }
        public List<eCuaHang> GetALLCuaHang()
        {
            return Cuahang.GetALLCuaHang();
        }
        public void ThemCuaHang(eCuaHang Ch)
        {
            Cuahang.InsertCuaHang(Ch);
        }
        public bool XoaCuaHang(string MaCuaHang)
        {
            return Cuahang.DeleteCuaHang(MaCuaHang);
        }
        public int DemSoLuongCuaHang()
        {
            return Cuahang.CountSLCuaHang();
        }
    }
}
