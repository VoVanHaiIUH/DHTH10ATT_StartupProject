using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.DaoTao
{
    public class QuaTrinhDaoTao_DAL
    {
        SPRHR_SolutionDataContext db;
        public QuaTrinhDaoTao_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        
        public List<BusinessEntities.NhanSu.eQuaTrinhDaoTao> LayDanhSach()
        {
            var c = from i in db.QuaTrinhDaoTaos
                    select
                    new BusinessEntities.NhanSu.eQuaTrinhDaoTao(i.maNhanVien, i.maChuongTrinhDaoTao, i.loaiDanhGia, i.ngayDuocDaoTao, i.ngayKetThucDaoTao);
            return c.ToList();
        }
        public BusinessEntities.NhanSu.eQuaTrinhDaoTao Them(DataAccessLayer.QuaTrinhDaoTao Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.QuaTrinhDaoTaos.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eQuaTrinhDaoTao(Moi.maNhanVien,Moi.maChuongTrinhDaoTao,Moi.loaiDanhGia,Moi.ngayDuocDaoTao,Moi.ngayKetThucDaoTao);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        int Check(IQueryable<QuaTrinhDaoTao> c)
        {
            if (c.Count() == 0) return -1;
            foreach (DataAccessLayer.QuaTrinhDaoTao i in c.ToList())
            {
                if (DateTime.Now.CompareTo(i.ngayDuocDaoTao) == -1)
                {
                    double K1 = i.ngayDuocDaoTao.Subtract(DateTime.Now).TotalDays;
                    double K2 = i.ngayKetThucDaoTao.Subtract(i.ngayDuocDaoTao).TotalDays;
                    if (K1 >= (K2 / 4)) return -2;
                }
            }
            return 1;
        }
        public int Xoa1NhanVien(string MaChuongTrinh,string MaNhanVien)
        {
            var c = from i in db.QuaTrinhDaoTaos where i.maChuongTrinhDaoTao.Equals(MaChuongTrinh) && i.maNhanVien.Equals(MaNhanVien) select i;
            int x = Check(c);
            if (x != 1) return x;
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.QuaTrinhDaoTaos.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                return 1;
            }
            catch
            {       
                db.Transaction.Rollback();
                return 0;
            }
        }
        public int XoaTatCaNhanVien(string MaChuongTrinh)
        {
            var c = from i in db.QuaTrinhDaoTaos where i.maChuongTrinhDaoTao.Equals(MaChuongTrinh) select i;
            int x = Check(c);
            if (x != 1) return x;
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.QuaTrinhDaoTaos.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                db.Transaction.Rollback();
                return 0;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eQuaTrinhDaoTao Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.QuaTrinhDaoTaos where i.maNhanVien.Equals(Moi.MaNhanVien) && i.maChuongTrinhDaoTao.Equals(Moi.MaChuongTrinhDaoTao) select i;
                foreach (DataAccessLayer.QuaTrinhDaoTao i in c.ToList())
                {
                    i.ngayDuocDaoTao = Moi.NgayDuocDaotao;
                    i.ngayKetThucDaoTao = Moi.NgayKetThucDaoTao;
                    i.loaiDanhGia = Moi.LoaiDanhGia;
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
