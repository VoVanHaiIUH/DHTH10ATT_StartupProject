using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.PhongBan
{
    class QuanLiPhongBan_DAL
    {
        SPRHR_SolutionDataContext db;
        public QuanLiPhongBan_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<BusinessEntities.NhanSu.ePhongBan> DanhSachPhongBan()
        {
            return (from i in db.PhongBans select new BusinessEntities.NhanSu.ePhongBan(i.maPhongBan, i.tenPhongBan, i.khuVuc, i.maTruongPhong)).ToList();
        }
        public string TaoMa()
        {
            try
            {
                string c = db.PhongBans.Last().maPhongBan;
                int n;
                bool x = int.TryParse(c.Substring(2, 2), out n);
                if (x == false) return "PB01";
                return "PB" + n.ToString("000");
            }
            catch
            {
                return "PB01";
            }
        }
        public BusinessEntities.NhanSu.ePhongBan ThemPhongBan(DataAccessLayer.PhongBan Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                Moi.maPhongBan = TaoMa();
                db.PhongBans.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.ePhongBan(Moi.maPhongBan,Moi.tenPhongBan,Moi.khuVuc,Moi.maTruongPhong);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool SetTruongPhong(string MaTP,string MaPB)
        {
            int x = (from i in db.PhongBans where i.maTruongPhong.Equals(MaTP) select i).Count();
            if (x != 0) return false;
            var c = from i in db.PhongBans where i.maPhongBan.Equals(MaPB) select i;
            try
            {
                foreach (var i in c.ToList())
                {
                    i.maTruongPhong = MaTP;
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
