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
        SPRHR_SolutionDataContext db;
        public PhieuNhapKho_dal()
        {
            db = new SPRHR_SolutionDataContext();
        }

        public List<ePhieuDeNghiNhapKho> GetPDNNK()
        {
            List<ePhieuDeNghiNhapKho> ls = new List<ePhieuDeNghiNhapKho>();
            foreach (PhieuDNNK pdn in db.PhieuDNNKs)
            {
                if (pdn.tinhtrang != 1)
                {
                    ls.Add(new ePhieuDeNghiNhapKho(pdn.MaPhieuDNNK, pdn.MaNhanVien, pdn.MaHoaDonNCC, pdn.MaKho, pdn.MoTa, pdn.NgayLap, pdn.tinhtrang));
                }
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
                ls.Add(new ePhieuNhapKho(pn.sopdnn, pn.manhanvien, pn.makho, pn.ngaylap));
            }
            return ls;
        }

        public List<ePhieuNhapKho> GetPNKtheoMa(string ma)
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach (PhieuNhapKho pn in db.PhieuNhapKhos.Where(p => p.sopdnn == ma))
            {
                ls.Add(new ePhieuNhapKho(pn.sopdnn, pn.manhanvien, pn.makho, pn.ngaylap));
            }
            return ls;
        }

        public IEnumerable<object> GetTTPhieuNhapKho(string maphieu)
        {
            var ls = db.PhieuNhapKhos.Where(e => e.sopdnn == maphieu).Select(x => new
            {
                x.makho,
                x.manhanvien,
                x.ngaylap,

                x.PhieuDNNK.NgayLap,
                x.PhieuDNNK.MaNhanVien,
                x.PhieuDNNK.MoTa,
                x.PhieuDNNK.ChiTietPhieuDNNKs,
                ////SanPham
                //
                //
            });
            return ls.ToList();
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

        private void UpdateTinhTrang(ePhieuNhapKho pnk)
        {
            PhieuDNNK p = db.PhieuDNNKs.Where(pdn => pdn.MaPhieuDNNK == pnk.SoPDNN).FirstOrDefault();
            p.tinhtrang = 1;
            db.SubmitChanges();
        }

        public int TaoPNK(ePhieuNhapKho pnk)
        {
            if (KtraTonTai(pnk.SoPDNN))
                return 0;

            PhieuNhapKho pn = new PhieuNhapKho();
            pn.sopdnn = pnk.SoPDNN;
            pn.manhanvien = pnk.MaNV;
            pn.makho = pnk.MaKho;
            pn.ngaylap = pnk.NgayLap;
            db.PhieuNhapKhos.InsertOnSubmit(pn);
            db.SubmitChanges();

            //Chuyen tinh trang phi?u DNNK đ? nh?p => 1
            UpdateTinhTrang(pnk);
            return 1;
        }
    }
}
