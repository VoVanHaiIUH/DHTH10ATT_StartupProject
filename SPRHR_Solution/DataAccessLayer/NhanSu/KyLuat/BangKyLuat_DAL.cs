using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.KyLuat
{
    public class BangKyLuat_DAL
    {
        SPRHR_SolutionDataContext db;
        public BangKyLuat_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<BusinessEntities.NhanSu.eKyLuat> LayDanhSach()
        {
            return (from i in db.KyLuats select new BusinessEntities.NhanSu.eKyLuat(i.maKyLuat, i.dieuKhoanKyLuat, i.hinhThucKyLuat)).ToList();
        }
        public bool SuaKyLuat(string MKL)
        {
            var c = from i in db.KyLuats where i.maKyLuat.Equals(MKL) select i;
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.KyLuats.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                db.Transaction.Commit();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
            }
        }
        public bool ThemKyLuat(DataAccessLayer.KyLuat Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.KyLuats where i.maKyLuat.Equals(Moi.maKyLuat) select i;
                foreach (DataAccessLayer.KyLuat i in c.ToList())
                {
                    i.hinhThucKyLuat = Moi.hinhThucKyLuat;
                    i.dieuKhoanKyLuat = Moi.dieuKhoanKyLuat;
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                db.Transaction.Rollback();
                return false;
            }
        }
    }
}
