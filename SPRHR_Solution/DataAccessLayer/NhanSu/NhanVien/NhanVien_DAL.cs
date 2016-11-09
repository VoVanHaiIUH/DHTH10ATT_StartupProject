using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.NhanSu.NhanVien
{
    public class NhanVien_DAL
    {
        SPRHR_SolutionDataContext db;
        public NhanVien_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<BusinessEntities.NhanSu.eNhanVien> DanhSachAll()
        {
            return (from i in db.NhanViens
                    select new
BusinessEntities.NhanSu.eNhanVien(i.maNhanVien, i.hoTenNhanVien, i.ngayBatDauLamViec, i.tinhTrang, i.soDT, i.soDT, i.queQuan, i.Email, i.soCMND, i.diaChi, i.gioiTinh, i.ngaySinh)).ToList();
        }
        public List<BusinessEntities.NhanSu.eNhanVien> DanhSachNhanVienHientai()
        {
            return (from i in DanhSachAll() where i.TinhTrang != "Nghi Viec" select i).ToList();
        }
        public List<BusinessEntities.NhanSu.eNhanVien> DanhSachNhanVienPhongBan(string MaPB)
        {
            LichSuLamViec_DAL Ls = new LichSuLamViec_DAL();
            var c = from i in DanhSachNhanVienHientai()
                    join j in Ls.DachSachLichHienTai()
                    on i.MaNhanVien equals j.MaNhanVien
                    where j.MaPhongBan.Equals(MaPB)
                    select i;
            return c.ToList();
        }
        public BusinessEntities.NhanSu.eNhanVien ThongTinNhanVien(string MaNV)
        {
            var c = from i in DanhSachAll() where i.MaNhanVien.Equals(MaNV) select i;
            try
            {
                return c.Last();
            }
            catch
            {
                return null;
            }
        }
        public string TaoMa()
        {
            string s = db.NhanViens.Last().maNhanVien;
            try
            {
                s = s.Substring(4, 4);
                int n = 0;
                bool x = int.TryParse(s, out n);
                if (x) return "NV" + (n + 1).ToString("0000");
                else return "NV0001";
            }
            catch
            {
                return "NV0001";
            }
        }
        public BusinessEntities.NhanSu.eNhanVien Them(DataAccessLayer.NhanVien Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                Moi.maNhanVien = TaoMa();
                db.NhanViens.InsertOnSubmit(Moi);
                db.SubmitChanges();
                return new BusinessEntities.NhanSu.eNhanVien(Moi.maNhanVien, Moi.hoTenNhanVien, Moi.ngayBatDauLamViec,
                    Moi.tinhTrang, Moi.soDT, Moi.soDT, Moi.queQuan, Moi.Email, Moi.soCMND, Moi.diaChi, Moi.gioiTinh, Moi.ngaySinh);
            }
            catch
            {
                db.Transaction.Rollback();
                return null;
            }
        }
        public bool Sua(BusinessEntities.NhanSu.eNhanVien Moi)
        {
            try
            {
                db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();
                var c = from i in db.NhanViens where i.maNhanVien.Equals(Moi.MaNhanVien) select i;
                foreach (DataAccessLayer.NhanVien i in c.ToList())
                {
                    i.hoTenNhanVien = Moi.HoTenNhanVien;
                    i.soTKNganHang = Moi.SoTKNganHang;
                    i.queQuan = Moi.QueQuan;
                    i.soCMND = Moi.SoCMND;
                    i.soDT = Moi.SoDT;
                    i.tinhTrang = Moi.TinhTrang;
                    i.ngaySinh = Moi.NgaySinh;
                    i.gioiTinh =  Moi.GioTinh;
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
