using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.HoaDonBanSiChoKhachHang
{
    public class LapHoaDonBanSi_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongHoaDon(string MaHoaDon)
        {
            var HoaDon = from i in db.HoaDonBanSis
                         where i.MaHoaDonBanSi == MaHoaDon
                         select i;
            if(HoaDon.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int CountSlHoaDonBanSi()
        {
            int n = db.HoaDonBanSis.Count();
            return n;
        }
        public int CountSlChiTietHoaDonBanSiByMa(string MaHoaDon)
        {
            int n = db.ChiTietHoaDonBanSis.Where(x => x.MaHoaDonBanSi == MaHoaDon).Count();
            return n;
        }
        public void InsertHoaDonBanSi(eHoaDonBanSi HoaDon)
        {
            HoaDonBanSi Hd = new HoaDonBanSi();
            Hd.MaHoaDonBanSi = TaoMaHoaDonBanSi();
            Hd.MaKH = HoaDon.MaKH;
            Hd.MaNhanVien = HoaDon.MaNhanVien;
            Hd.NgayLap = DateTime.Now;
            Hd.MoTa = HoaDon.MoTa;
            Hd.TongTien = 0;
        }
        public int InsertChiTietHoaDonBanSi(eChiTietHoaDonBanSi Ct)
        {
            var SanPham = from i in db.SanPhams
                          where i.MaSP == Ct.MaSP
                          select i;
            if(SanPham.Any())
            {
                var ChiTiet = from i in db.ChiTietHoaDonBanSis
                              where i.MaHoaDonBanSi == Ct.MaHoaDonoBanSi && i.MaSP == Ct.MaSP 
                              select i;
                if(ChiTiet.Any())
                {
                    return 0;
                }
                else
                {
                    ChiTietHoaDonBanSi ChitietHDBS = new ChiTietHoaDonBanSi();
                    ChitietHDBS.MaHoaDonBanSi = Ct.MaHoaDonoBanSi;
                    ChitietHDBS.MaSP = Ct.MaSP;
                    ChitietHDBS.SoLuong = Ct.soluong;
                    ChitietHDBS.GhiChu = Ct.GhiChu;
                    ChitietHDBS.GiaBanSi = Ct.GiaBanSi;
                    decimal Money = Ct.soluong * Ct.GiaBanSi;
                    UpdateTongTienHoaDonBanSiI(Ct.MaHoaDonoBanSi, Money);
                    db.ChiTietHoaDonBanSis.InsertOnSubmit(ChitietHDBS);
                    db.SubmitChanges();
                    return 1;
                }
            }
            else
            {
                return 2;
            }
        }

        private void UpdateTongTienHoaDonBanSiI(string MaHoaDon,decimal Gia)
        {
            HoaDonBanSi HoaDon = db.HoaDonBanSis.Where(x => x.MaHoaDonBanSi == MaHoaDon).FirstOrDefault();
            HoaDon.TongTien += Gia;
            db.SubmitChanges();
        }
        private void UpdateTongTienHoaDonBanSiD(string MaHoadon,decimal Gia)
        {
            HoaDonBanSi HoaDon = db.HoaDonBanSis.Where(x => x.MaHoaDonBanSi == MaHoadon).FirstOrDefault();
            HoaDon.TongTien -= Gia;
            db.SubmitChanges();
        }
        private string TaoMaHoaDonBanSi()
        {
            int max = 0;
            foreach (HoaDonBanSi HD in db.HoaDonBanSis)
            {
                int t = int.Parse(HD.MaHoaDonBanSi.Substring(4));
                if (t >= max)
                    max = t;
            }
            max++;
            return "HDBS" + string.Format("{0:0000}", max);
        }
      
        public void DeleteChiTietHoaDonBanSi(string MaHoaDonBanSi,string MaSp,string MaChiTietHoaDonBanSi)
        {
            ChiTietHoaDonBanSi Chitiet = db.ChiTietHoaDonBanSis.Where(x => x.MaHoaDonBanSi == MaHoaDonBanSi &&  x.MaSP == MaSp).FirstOrDefault();
            decimal Money = Convert.ToDecimal(Chitiet.GiaBanSi * Chitiet.SoLuong);
            db.ChiTietHoaDonBanSis.DeleteOnSubmit(Chitiet);
            db.SubmitChanges();
            UpdateTongTienHoaDonBanSiD(MaHoaDonBanSi, Money);
        }
        // delete HoaDonBanSi hien khong co rang buoc voi phieu de nghi xuat kho
        public void DeleteHoaDonNhaCungCap(string MaHoaDonNhaCungCap)
        {
            HoaDonNhaCungCap HoaDon = db.HoaDonNhaCungCaps.Where(x => x.MaHoaDonNCC == MaHoaDonNhaCungCap).FirstOrDefault();
            db.HoaDonNhaCungCaps.DeleteOnSubmit(HoaDon);
            db.SubmitChanges();
        }
    }
}
