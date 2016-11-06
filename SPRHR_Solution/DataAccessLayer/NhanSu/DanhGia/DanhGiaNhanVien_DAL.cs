using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BusinessEntities;
namespace DataAccessLayer.NhanSu.DanhGia
{
    public class DanhGiaNhanVien_DAL
    {
        SPRHR_SolutionDataContext db;
        public DanhGiaNhanVien_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public bool KTLoaiDanhGia(string LDG)
        {
            return Regex.Match(LDG.ToUpper(),"^[ABCD][WMQY]$").Success;
        }
        public BusinessEntities.NhanSu.eDanhGia Them(DataAccessLayer.DanhGia Moi)
        {
            try
            {
                db.DanhGias.InsertOnSubmit(Moi);
                db.SubmitChanges();
                Moi.ngayDanhGia = DateTime.Now;
                BusinessEntities.NhanSu.eDanhGia M = new BusinessEntities.NhanSu.eDanhGia(Moi.maNhanVien,Moi.ngayDanhGia,Moi.loaiDanhGia,Moi.ghiChu);
                return M;
            }
            catch(Exception ex)
            {
                throw new Exception (ex.Message);     
            }
        }
        public int Xoa(string MaNhanVien,DateTime NgayDanhGia)
        {
            var c = from i in db.DanhGias
                    where i.maNhanVien.Equals(MaNhanVien) && i.ngayDanhGia.Equals(NgayDanhGia)
                    select i;
            if (c.Count() == 0) return -1;
            try
            {
                db.DanhGias.DeleteAllOnSubmit(c);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public bool Sua(DataAccessLayer.DanhGia Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.DanhGias where i.maNhanVien.Equals(Moi.maNhanVien) && i.ngayDanhGia.Equals(Moi.ngayDanhGia) select i;
                foreach (DataAccessLayer.DanhGia i in c.ToList())
                {
                    i.loaiDanhGia = Moi.loaiDanhGia;
                    i.ghiChu = Moi.ghiChu;
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
        public List<BusinessEntities.NhanSu.eDanhGia> LayDanhSach()
        {
            var c = from i in db.DanhGias select new BusinessEntities.NhanSu.eDanhGia(i.maNhanVien,i.ngayDanhGia,i.loaiDanhGia,i.ghiChu);
            return c.ToList();
        }
    }
}
