using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.NhanVien
{
    public class LichSuLamViec_DAL
    {
        SPRHR_SolutionDataContext db;
        public LichSuLamViec_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<BusinessEntities.NhanSu.eLichSuLamViec> DanhSachLichAll()
        {
            return (from i in db.lichSuLamViecs select new BusinessEntities.NhanSu.eLichSuLamViec(i.maNhanVien, i.maPhongBan, i.ngayBatDauLamViec, (DateTime)i.ngayKetThuc, i.maChucVu)).ToList();
        }
        public List<BusinessEntities.NhanSu.eLichSuLamViec> DachSachLichHienTai()
        {
            return (from i in DanhSachLichAll()
                    where
                    DateTime.Compare(i.NgayBatDauLamViec, DateTime.Now) != 1 &&
                    DateTime.Compare(DateTime.Now,i.NgayKetThuc) <= 0
                    select i).ToList();
        }
        public List<BusinessEntities.NhanSu.eLichSuLamViec> NV_LSLamViec(string MaNV)
        {
            return ( from i in DanhSachLichAll() where i.MaNhanVien.Equals(MaNV) select i).ToList();
        }
        DataAccessLayer.lichSuLamViec TimLichSuHienTai(string maNhanVien)
        {
            var c = from i in db.lichSuLamViecs where i.maNhanVien.Equals(maNhanVien) select i;
            return c.Last();
        }
        public BusinessEntities.NhanSu.eLichSuLamViec Them(DataAccessLayer.lichSuLamViec Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                try
                {
                    TimLichSuHienTai(Moi.maNhanVien).ngayKetThuc = DateTime.Now;
                }
                catch { }
                Moi.ngayBatDauLamViec = DateTime.Now;
                db.lichSuLamViecs.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eLichSuLamViec(Moi.maNhanVien, Moi.maPhongBan,Moi.ngayBatDauLamViec,(DateTime)Moi.ngayKetThuc,Moi.maChucVu);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eLichSuLamViec Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.lichSuLamViecs where i.maNhanVien.Equals(Moi.MaNhanVien) select i;
                DataAccessLayer.lichSuLamViec K = c.Last();
                K.maChucVu = Moi.MaChucVu;
                K.maPhongBan = Moi.MaPhongBan;
                K.ngayKetThuc = Moi.NgayKetThuc;
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
