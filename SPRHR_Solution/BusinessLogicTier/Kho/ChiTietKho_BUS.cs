using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Kho;
namespace BusinessLogicTier.Kho
{
    public class ChiTietKho_BUS
    {
        ChiTietKho_dal ct;
        public ChiTietKho_BUS()
        {
            ct = new ChiTietKho_dal();
        }
        public List<eChiTietKho> GetSpByMakho(string makho)
        {
            return ct.GetSpByMakho(makho);
        }
        public List<eSanPham> GetThongTinSp(string masp)
        {
            return ct.GetThongTinSp(masp);
        }
    }
}
