using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.DaoTao
{
    public class ChuongTrinhDaoTao_DAL
    {
        SPRHR_SolutionDataContext db;
        public ChuongTrinhDaoTao_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public string TaoMa()
        {
            string s = db.ChuongTrinhDaoTaos.Last().machuongTrinhDaoTao;
            try
            {
                s = s.Substring(4, 4);
                int n = 0;
                int.TryParse(s, out n);
                if (n == -1) return "";
                else return "CTDT" + (n + 1).ToString("0000");
            }
            catch
            {
                return "CTDT0001";
            }
        }
        public List<BusinessEntities.NhanSu.eChuongTrinhDaoTao> LayDanhSach()
        {
            var c = from i in db.ChuongTrinhDaoTaos select new BusinessEntities.NhanSu.eChuongTrinhDaoTao(i.machuongTrinhDaoTao, i.tenChuongTrinhDaoTao, i.ghiChu, i.coSoDaoTao);
            return c.ToList();
        }
        public BusinessEntities.NhanSu.eChuongTrinhDaoTao Them(DataAccessLayer.ChuongTrinhDaoTao Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.ChuongTrinhDaoTaos.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eChuongTrinhDaoTao(Moi.machuongTrinhDaoTao, Moi.tenChuongTrinhDaoTao, Moi.ghiChu, Moi.coSoDaoTao);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public int Xoa(string MaChuongTrinh)
        {
            var c = from i in db.ChuongTrinhDaoTaos where i.machuongTrinhDaoTao.Equals(MaChuongTrinh) select i;
            if (c.Count() == 0) return -1;
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                QuaTrinhDaoTao_DAL Q = new QuaTrinhDaoTao_DAL();
                int x = Q.XoaTatCaNhanVien(MaChuongTrinh);
                if (x == 0) return 0;
                db.ChuongTrinhDaoTaos.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                db.Transaction.Rollback();
                return 0;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eChuongTrinhDaoTao Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.ChuongTrinhDaoTaos where i.machuongTrinhDaoTao.Equals(Moi.MaChuongTrinhDaoTao) select i;
                foreach (DataAccessLayer.ChuongTrinhDaoTao i in c.ToList())
                {
                    i.tenChuongTrinhDaoTao = Moi.TenChuongTrinhDaoTao;
                    i.ghiChu = Moi.GhiChu;
                    i.coSoDaoTao = Moi.coSoDaoTao;
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
