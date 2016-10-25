using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BanHang;

namespace DataAccessLayer.BanHang.LapPhieuBanHang
{
    public class LapPhieuBanHang_DAL
    {
        SPRHR_SolutionDataContext db;
        public LapPhieuBanHang_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }

        public bool ktranhvien(string manv)
        {
            var linq = (from nv in db.NhanViens
                        where nv.maNhanVien == manv
                        select nv).Count();
            if (linq == 0) return false;
            return true;
        }

        public bool ktrakhhang(string makh)
        {
            var linq = (from kh in db.KhachHangs
                        where kh.MaKH == makh
                        select kh).Count();
            if (linq == 0) return false;
            return true;
        }

        public void themHoaDon(string manv, string makh, DateTime ngaylap,decimal tongtien,bool vat)
        {
            HoaDonBanHang hdbh = new HoaDonBanHang();
            hdbh.soHD = (decimal.Parse(db.HoaDonBanHangs.Last().soHD) + 1).ToString();
            hdbh.maNV = manv;
            hdbh.maKH = makh;
            hdbh.ngayLap = ngaylap;
            hdbh.tongTien = tongtien;
            hdbh.VAT = vat;
            db.HoaDonBanHangs.InsertOnSubmit(hdbh);
            db.SubmitChanges();
        }
    }
}
