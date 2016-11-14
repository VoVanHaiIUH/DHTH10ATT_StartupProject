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
    }
}
