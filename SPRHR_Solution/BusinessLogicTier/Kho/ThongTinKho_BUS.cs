using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Kho;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;

namespace BusinessLogicTier.Kho
{
    
    public class ThongTinKho_BUS
    {
        ThongTinKho_dal tt;
        ChiTietKho_dal ct;
        public ThongTinKho_BUS()
        {
            tt = new ThongTinKho_dal();
            ct = new ChiTietKho_dal();
        }
        public List<eThongTinKho> GetThongTinKho()
        {
            return tt.GetThongTinKho();
        }
        public List<eThongTinKho> GetThongTinbyMa(string makho)
        {
            return tt.GetThongTinbyMa(makho);
        }

    }
}
