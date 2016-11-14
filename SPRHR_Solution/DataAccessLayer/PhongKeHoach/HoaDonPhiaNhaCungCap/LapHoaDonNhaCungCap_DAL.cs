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
            Hd.sotienDatra = HoaDon.SoTienDaTra;
            db.HoaDonNhaCungCaps.InsertOnSubmit(Hd);
            db.SubmitChanges();
        }
        public bool InsertChiTietHoaDonNhaCungCap(string mahd,string masp, int soluong, decimal  giamua,string ghichu)
        {
            var c = from i in db.ChiTietHoaDonNhaCungCaps
                    where i.MaHoaDonNhaCungCap == mahd && i.MaSPNCC == masp
                    select i;
            if (c.Any())
            {
                throw new Exception("There Already Have");
            }
            else
            {
                ChiTietHoaDonNhaCungCap ct = new ChiTietHoaDonNhaCungCap();
                ct.MaHoaDonNhaCungCap = mahd;
                ct.SoLuong = soluong;
                ct.MaSPNCC = masp;
                ct.GiaMuaBenNhaCungCap = giamua;
                ct.GhiChu = ghichu;
                db.ChiTietHoaDonNhaCungCaps.InsertOnSubmit(ct);
                db.SubmitChanges();
                InsertSanPhamNhaCungCap(masp, soluong);
                decimal n = giamua*(decimal)1.05;
                InsertOfUpdateBangGiaSi(masp,giamua.ToString());
                return true;
            }
        }
        private void InsertSanPhamNhaCungCap(string MaSp,int soluong)
        {
            foreach(SanPham sp in db.SanPhams.ToList())
            {
                if(sp.MaSP == MaSp)
                {
                    sp.soluong += soluong;
                }
                else
                {
                    SanPham s = new SanPham();
                    s.MaSP = MaSp;
                    s.KieuDang ="";
                    s.MauSac ="";
                    s.NgayHetHan =Convert.ToDateTime("");
                    s.NgaySanXuat =Convert.ToDateTime("");
                    s.TrongLuong = float.Parse("");
                    s.Mota ="";
                    s.MaLoaiSanPham = "";
                    s.TenSp = "";
                    s.DonViTinh = "";
                    db.SanPhams.InsertOnSubmit(s);
                    db.SubmitChanges();
                }
            }
        }
        private void InsertOfUpdateBangGiaSi(string masp,string Gia)
        {
            foreach(BangGiaBanSi ba in db.BangGiaBanSis.ToList())
            {
                if(ba.maSP == masp)
                {
                    ba.giaBan = Gia;
                }
                else
                {
                    BangGiaBanSi s = new BangGiaBanSi();
                    s.maSP = masp;
                    s.giaBan = Gia;
                    db.BangGiaBanSis.InsertOnSubmit(s);
                    db.SubmitChanges();
                }
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
        public List<eHoaDonNhaCungCap> GetAllHoaDonNCC()
        {
            var q = from i in db.HoaDonNhaCungCaps join j in db.PhieuDNNKs 
                                                   on i.MaHoaDonNCC equals j.MaHoaDonNCC
                                                   where i.MaHoaDonNCC != j.MaHoaDonNCC
                                                   select i;
            List<eHoaDonNhaCungCap> ls = new List<eHoaDonNhaCungCap>();
            foreach (HoaDonNhaCungCap a in q.ToList())
            {
                ls.Add(new eHoaDonNhaCungCap (a.MaHoaDonNCC,a.MaNhaCungCap,a.MaNhanVien,(DateTime)a.NgayLap,(decimal)a.TongTien,(decimal)a.sotienDatra));
            }
            return ls;
        }
        public List<eHoaDonNhaCungCap> GetHoaDonByMa(string mahdncc)
        {
            var q = from i in db.HoaDonNhaCungCaps
                    where i.MaHoaDonNCC == mahdncc
                    select i;
            List<eHoaDonNhaCungCap> ls = new List<eHoaDonNhaCungCap>();
            foreach (HoaDonNhaCungCap a in q.ToList())
            {
                ls.Add(new eHoaDonNhaCungCap (a.MaHoaDonNCC,a.MaNhaCungCap,a.MaNhanVien,(DateTime)a.NgayLap,(decimal)a.TongTien,(decimal)a.sotienDatra));
            }
            return ls;
        }
        public List<eChiTietHoaDonNhaCungCap> GetALlChiTietNCCByMaHDNCC(string mahdncc)
        {
            var q = from x in db.ChiTietHoaDonNhaCungCaps
                    where x.MaHoaDonNhaCungCap == mahdncc
                    select x;
            List<eChiTietHoaDonNhaCungCap> ls = new List<eChiTietHoaDonNhaCungCap> ();
            foreach (ChiTietHoaDonNhaCungCap a in q.ToList())
            {
                ls.Add(new eChiTietHoaDonNhaCungCap(a.MaSPNCC,a.MaHoaDonNhaCungCap,(int)a.SoLuong,(decimal)a.GiaMuaBenNhaCungCap,a.GhiChu));
            }
            return ls;
        }
    }
}
