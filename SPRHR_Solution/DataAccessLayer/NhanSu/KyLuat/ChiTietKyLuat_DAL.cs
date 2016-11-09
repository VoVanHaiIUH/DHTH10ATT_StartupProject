using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.KyLuat
{
    public class ChiTietKyLuat_DAL
    {
        SPRHR_SolutionDataContext db;
        public ChiTietKyLuat_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public BusinessEntities.NhanSu.eChiTietKyLuat Them(DataAccessLayer.ChiTietKyLuat Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                db.ChiTietKyLuats.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eChiTietKyLuat(Moi.maKyLuat, Moi.maNhanVien, Moi.lyDo, Moi.ngayLapKyLuat, Moi.ngayApDungKyLuat, (DateTime)Moi.ngayKetThucKyLuat);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eChiTietKyLuat Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.ChiTietKyLuats where i.maNhanVien.Equals(Moi.MaNhanVien) && i.maKyLuat.Equals(Moi.MaKyLuat) select i;
                foreach (DataAccessLayer.ChiTietKyLuat i in c.ToList())
                {
                    i.ngayApDungKyLuat = Moi.NgayApDungKyLuat;
                    i.ngayKetThucKyLuat = Moi.NgayKetThucKyLuat;
                    i.ngayLapKyLuat = i.ngayLapKyLuat;
                    i.lyDo = Moi.LyDo;
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
        public List<BusinessEntities.NhanSu.eChiTietKyLuat> LayDanhSach()
        {
            return (from i in db.ChiTietKyLuats
                    select new 
                    BusinessEntities.NhanSu.eChiTietKyLuat(i.maKyLuat, i.maNhanVien, i.lyDo, i.ngayLapKyLuat, i.ngayApDungKyLuat, (DateTime)i.ngayKetThucKyLuat)).ToList();
        }
    }
}
