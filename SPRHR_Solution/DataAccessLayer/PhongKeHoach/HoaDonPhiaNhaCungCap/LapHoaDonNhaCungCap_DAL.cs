using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.HoaDonPhiaNhaCungCap
{
    public class LapHoaDonNhaCungCap_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongHoaDon(string MaHoaDon)
        {
            var HoaDon = from i in db.ChiTietHoaDonNhaCungCaps
                         where i.MaHoaDonNhaCungCap == MaHoaDon
                         select i;
            if (HoaDon.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CountSlHoaDonNhaCungCap()
        {
            int n = db.ChiTietHoaDonNhaCungCaps.Count();
            return n;
        }
        public int CountSlChiTietHoaDonNhaCungCapByMa(string MaHoaDon)
        {
            int n = db.ChiTietHoaDonNhaCungCaps.Where(x => x.MaHoaDonNhaCungCap == MaHoaDon).Count();
            return n;
        }
        public void InsertHoaDonNhaCungCap(eHoaDonNhaCungCap HoaDon)
        {
            HoaDonNhaCungCap Hd = new HoaDonNhaCungCap();
            Hd.MaHoaDonNCC = TaoMaHoaDonNhaCungCap();
            Hd.MaNhaCungCap = HoaDon.MaNhaCungCap;
            Hd.MaNhanVien = HoaDon.MaNhanVien;
            Hd.NgayLap = DateTime.Now;
            Hd.TongTien = 0;
        }
        public int InsertChiTietHoaDonNhaCungCap(eChiTietHoaDonNhaCungCap Ct)
        {
            var SanPham = from i in db.SanPhams
                          where i.MaSP == Ct.MaSp
                          select i;
            if (SanPham.Any())
            {
                var ChiTiet = from i in db.ChiTietHoaDonNhaCungCaps
                              where i.MaHoaDonNhaCungCap == Ct.MaHoaDonNhaCungCap && i.MaSp == Ct.MaSp
                              select i;
                if (ChiTiet.Any())
                {
                    return 0;
                }
                else
                {
                    ChiTietHoaDonNhaCungCap ChitietHDNCC = new ChiTietHoaDonNhaCungCap();
                    ChitietHDNCC.MaHoaDonNhaCungCap = Ct.MaHoaDonNhaCungCap;
                    ChitietHDNCC.MaSp = Ct.MaSp;
                    ChitietHDNCC.SoLuong = Ct.SoLuong;
                    ChitietHDNCC.GhiChu = Ct.GhiChu;
                    ChitietHDNCC.GiaMuaBenNhaCungCap = Ct.GiaMuaBenNhaCungCap;
                    decimal Money = Ct.SoLuong * Ct.GiaMuaBenNhaCungCap;
                    UpdateTongTienHoaDonNhaCungCapI(Ct.MaHoaDonNhaCungCap, Money);
                    db.ChiTietHoaDonNhaCungCaps.InsertOnSubmit(ChitietHDNCC);
                    db.SubmitChanges();
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }

        private void UpdateTongTienHoaDonNhaCungCapI(string MaHoaDon, decimal Gia)
        {
            HoaDonNhaCungCap HoaDon = db.HoaDonNhaCungCaps.Where(x => x.MaHoaDonNCC == MaHoaDon).FirstOrDefault();
            HoaDon.TongTien += Gia;
            db.SubmitChanges();
        }
        public void UpdateTongTienHoaDonNhaCungCapD(string MaHoadon, decimal Gia)
        {
            HoaDonNhaCungCap HoaDon = db.HoaDonNhaCungCaps.Where(x => x.MaHoaDonNCC == MaHoadon).FirstOrDefault();
            HoaDon.TongTien -= Gia;
            db.SubmitChanges();
        }
        private string TaoMaHoaDonNhaCungCap()
        {
            int max = 0;
            foreach (HoaDonBanSi HD in db.HoaDonBanSis)
            {
                int t = int.Parse(HD.MaHoaDonBanSi.Substring(5));
                if (t >= max)
                    max = t;
            }
            max++;
            return "HDNCC" + string.Format("{0:0000}", max);
        }
        private void DeleteChiTietHoaDonNhaCungCap(string MaHoaDonNhaCungCap, string MaSp)
        {
            ChiTietHoaDonNhaCungCap Chitiet = db.ChiTietHoaDonNhaCungCaps.Where(x => x.MaHoaDonNhaCungCap == MaHoaDonNhaCungCap && x.MaSp == MaSp).FirstOrDefault();
            decimal Money = Convert.ToDecimal(Chitiet.GiaMuaBenNhaCungCap * Chitiet.SoLuong);
            db.ChiTietHoaDonNhaCungCaps.DeleteOnSubmit(Chitiet);
            db.SubmitChanges();
            UpdateTongTienHoaDonNhaCungCapD(MaHoaDonNhaCungCap, Money);
        }
        public int DeleteHoaDonNhaCungCap(string MaHoaDon)
        {
            var PDNNK = from i in db.PhieuDNNKs
                        where i.MaHoaDonNCC == MaHoaDon
                        select i;
            if (PDNNK.Any())
            {
                return 0;
            }
            else
            {
                HoaDonNhaCungCap HoaDon = db.HoaDonNhaCungCaps.Where(x => x.MaHoaDonNCC == MaHoaDon).FirstOrDefault();
                db.HoaDonNhaCungCaps.DeleteOnSubmit(HoaDon);
                db.SubmitChanges();
                return 1;
            }
        }
    }
}
