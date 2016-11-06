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
        string TaoMaKyLuat()
        {
            string s = (db.KyLuats.Last()).maKyLuat;
            if (s.Length == 4)
            {
                s = s.Substring(2, 2);
                int x;
                bool t = int.TryParse(s, out x);
                if (t) return "KL" + (x + 1).ToString("00");
                else return "KL01";
            }
            else return "KL01";

        }
        public BusinessEntities.NhanSu.eKyLuat Them(DataAccessLayer.KyLuat Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                Moi.maKyLuat = TaoMaKyLuat();
                db.KyLuats.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eKyLuat(Moi.maKyLuat, Moi.dieuKhoanKyLuat, Moi.hinhThucKyLuat);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool SuaKyLuat(DataAccessLayer.KyLuat Moi)
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
