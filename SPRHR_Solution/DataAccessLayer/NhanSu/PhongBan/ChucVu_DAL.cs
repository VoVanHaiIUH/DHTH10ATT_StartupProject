using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.PhongBan
{
    public class ChucVu_DAL
    {
        SPRHR_SolutionDataContext db;
        public ChucVu_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<BusinessEntities.NhanSu.eChucVu> DanhSachAll()
        {
            return (from i in db.ChucVus select new BusinessEntities.NhanSu.eChucVu(i.maChucVu,i.tenChucVU,i.moTa)).ToList();
        }
        public string TaoMaChucVu()
        {
            string s = (db.ChucVus.Last()).maChucVu;
            if (s.Length == 4)
            {
                s = s.Substring(2, 2);
                int x;
                bool t = int.TryParse(s, out x);
                if (t) return "CV" + (x + 1).ToString("00");
                else return "CV01";
            }
            else return "CV01";
        }
        public BusinessEntities.NhanSu.eChucVu Them(DataAccessLayer.ChucVu Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                Moi.maChucVu = TaoMaChucVu();
                db.ChucVus.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eChucVu(Moi.maChucVu,Moi.tenChucVU,Moi.moTa);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eChucVu Moi)
        {
            try
            {
                
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.ChucVus where i.maChucVu.Equals(Moi.MaChucVu) select i;
                foreach (DataAccessLayer.ChucVu i in c.ToList())
                {
                    i.tenChucVU = Moi.TenChucVu;
                    i.moTa = Moi.MoTa;
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
