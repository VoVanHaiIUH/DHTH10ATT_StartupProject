using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;

namespace DataAccessLayer.Kho
{
    public class ThongTinKho_dal
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();

        public List<eThongTinKho> GetThongTinKho()
        {
            List<eThongTinKho> ls = new List<eThongTinKho>();
            foreach(ThongTinKho tt in db.ThongTinKhos)
            {
                ls.Add(new eThongTinKho(tt.maKho, tt.tenKho, tt.soDienThoai, tt.diaChi));
            }
            return ls;
        }
        public List<eThongTinKho> GetThongTinbyMa(string makho)
        {
            List<eThongTinKho> ls = new List<eThongTinKho>();
            foreach(ThongTinKho tt in db.ThongTinKhos.Where(k=>k.maKho == makho))
            {
                ls.Add(new eThongTinKho(tt.maKho, tt.tenKho, tt.soDienThoai, tt.diaChi));
            }
            return ls;
        }
    }
}
