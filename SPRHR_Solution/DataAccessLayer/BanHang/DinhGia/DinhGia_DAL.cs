using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BanHang.DinhGia
{
    public class DinhGia_DAL
    {
        DataAccessLayer.SPRHR_SolutionDataContext db;
        public DinhGia_DAL()
        {
            db = new DataAccessLayer.SPRHR_SolutionDataContext();
        }

        public List<BusinessEntities.BanHang.eGiaBan> LoadBangGia()
        {
            var linq = from gb in db.BangGiaBans
                       select gb;
            List<BusinessEntities.BanHang.eGiaBan> list = new List<BusinessEntities.BanHang.eGiaBan>();
            foreach (var item in linq.ToList())
            {
                BusinessEntities.BanHang.eGiaBan temp = new BusinessEntities.BanHang.eGiaBan(item.maSP, item.giaBan, item.ngayApDung);
                list.Add(temp);
            }
            return list;
        }
    }
}
