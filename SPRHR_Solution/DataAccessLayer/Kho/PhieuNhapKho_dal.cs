using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
namespace DataAccessLayer.Kho
{
    public class PhieuNhapKho_dal
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public List<ePhieuDeNghiNhapKho> GetPDNNK()
        {
            List<ePhieuDeNghiNhapKho> ls = new List<ePhieuDeNghiNhapKho>();
            foreach (PhieuDNNK pdn in db.PhieuDNNKs.Where(e => e.tinhtrang != 1))
            {
                ls.Add(new ePhieuDeNghiNhapKho(pdn.MaPhieuDNNK, pdn.MaNhanVien, pdn.MaHoaDonNCC, pdn.MaKho, pdn.MoTa, pdn.NgayLap, pdn.tinhtrang));
            }
            return ls;
        }

        public List<ePhieuDeNghiNhapKho> GetPDNNKbyMa(string ma)
        {
            List<ePhieuDeNghiNhapKho> ls = new List<ePhieuDeNghiNhapKho>();
            foreach (PhieuDNNK pdn in db.PhieuDNNKs.Where(p => p.MaPhieuDNNK == ma))
            {
                ls.Add(new ePhieuDeNghiNhapKho(pdn.MaPhieuDNNK, pdn.MaNhanVien, pdn.MaHoaDonNCC, pdn.MaKho, pdn.MoTa, pdn.NgayLap, pdn.tinhtrang));
            }
            return ls;
        }
        public List<ePhieuNhapKho> GetPNK()
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach (PhieuNhapKho pn in db.PhieuNhapKhos)
            {
                ls.Add(new ePhieuNhapKho(pn.sopnk, pn.manhanvien, pn.makho,pn.ghichu, pn.ngaylap));
            }
            return ls;
        }

        public List<ePhieuNhapKho> GetPNKtheoMa(string ma)
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach (PhieuNhapKho pn in db.PhieuNhapKhos.Where(p => p.sopnk == ma))
            {
                ls.Add(new ePhieuNhapKho(pn.sopnk, pn.manhanvien, pn.makho,pn.ghichu, pn.ngaylap));
            }
            return ls;
        }

        public IEnumerable<object> GetTTPhieuNhapKho(string maphieu)
        {
            PhieuDNNK pdnnk = db.PhieuDNNKs.Where(e => e.MaPhieuDNNK == maphieu).FirstOrDefault();
            var query = pdnnk.ChiTietPhieuDNNKs.Select(e => new
            {
                e.SanPham.MaSP,
                e.SanPham.TenSp,
                e.SoLuong,
                e.GhiChu
            });
            return query.ToList();
            
        }

        private bool KtraTonTai(string soPhieu)
        {
            PhieuDNNK p = db.PhieuDNNKs.Where(pdn => pdn.MaPhieuDNNK == soPhieu).FirstOrDefault();
            if (p != null)
            {
                return false;
            }
            return true;
        }

        public bool ktranv(string manv,string mk)
        {
            QuanLyKho ql = db.QuanLyKhos.Where(q => q.manhanvien == manv && q.maKho == mk && q.thoiGianKetThuc == null).FirstOrDefault();
            if (ql != null)
                return false;
            return true;
        }

        private void UpdateTinhTrang(ePhieuNhapKho pnk)
        {
            PhieuDNNK p = db.PhieuDNNKs.Where(pdn => pdn.MaPhieuDNNK == pnk.SoPDNN).FirstOrDefault();
            p.tinhtrang = 1;
            db.SubmitChanges();
        }

        //private void UpdateSoLuongSP(ePhieuNhapKho pnk)
        //{
        //    foreach(ChiTietPhieuDNNK ct in db.ChiTietPhieuDNNKs.Where(pdn => pdn.MaPhieuDNNK == pnk.SoPDNN))
        //    {
        //        foreach (ChiTietKho sp in db.ChiTietKhos)
        //        {
        //            sp.maKho = pnk.MaKho;
        //            sp.maSp = ct.MaSP;
        //            sp.soLuong += ct.SoLuong;
        //            db.ChiTietKhos.InsertOnSubmit(sp);
        //            db.SubmitChanges();
        //        }
        //    }
        //}

        private int TaoChiTietKho(string maphieu)
        {
            foreach(PhieuDNNK pdn in db.PhieuDNNKs.Where(p=>p.MaPhieuDNNK == maphieu))
            {
                foreach (ChiTietPhieuDNNK ctdn in db.ChiTietPhieuDNNKs.Where(e => e.MaPhieuDNNK == maphieu))
                {
                    ChiTietKho ctkho = db.ChiTietKhos.Where(k => k.maSP == ctdn.MaSP && k.maKho == pdn.MaKho).FirstOrDefault();
                    if(ctkho==null)
                    {
                        ChiTietKho ct = new ChiTietKho();
                        ct.maKho = pdn.MaKho;
                        ct.maSP = ctdn.MaSP;
                        ct.soLuong = ctdn.SoLuong;

                        db.ChiTietKhos.InsertOnSubmit(ct);
                        db.SubmitChanges();
                    }
                    else
                    {
                        ctkho.soLuong += ctdn.SoLuong;
                        db.SubmitChanges();
                    }
                }
            }
            return 1;
        }
        
        public int TaoPNK(ePhieuNhapKho pnk)
        {
            if (KtraTonTai(pnk.SoPDNN))
                throw new Exception("Không có phiếu đề nghị này");
            if (ktranv(pnk.MaNV,pnk.MaKho))
                throw new Exception("Bạn không phải nhân viên kho này");
            PhieuNhapKho pn = new PhieuNhapKho();
            pn.sopnk = pnk.SoPDNN;
            pn.manhanvien = pnk.MaNV;
            pn.makho = pnk.MaKho;
            pn.ghichu = pnk.GhiChu;
            pn.ngaylap = pnk.NgayLap;
            db.PhieuNhapKhos.InsertOnSubmit(pn);
            db.SubmitChanges();

            UpdateTinhTrang(pnk);//Chuyen tinh trang phieu DNNK da nhap
            TaoChiTietKho(pnk.SoPDNN);//Tao chi tiet kho, them maSp va soLuong theo kho đó
            return 1;
        }
    }
}
