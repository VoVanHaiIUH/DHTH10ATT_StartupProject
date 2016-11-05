using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using DataAccessLayer.PhongKeHoach.KeHoach;

namespace BusinessLogicTier.PhongKeHoach.KeHoach
{
    public class LapKeHoach_BUL
    {
        LapKeHoach_DAL KeHoach = new LapKeHoach_DAL();
        public List<eKeHoach> LapDanhSachKehoachChoSanPham(DateTime From,DateTime To)
        {
            return KeHoach.DanhSachKeHoachChoSanPham(From, To);
        }
    }
}
