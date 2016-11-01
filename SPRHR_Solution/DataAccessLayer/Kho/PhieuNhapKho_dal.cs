using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;
namespace DataAccessLayer.Kho
{
    public class PhieuNhapKho_dal
    {
        SPRHR_SolutionDataContext db;
        public PhieuNhapKho_dal()
        {
            db = new SPRHR_SolutionDataContext();
        }

        public List<ePhieuNhapKho> getpnk()
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach(PhieuNhapKho pn in db.PhieuNhapKhos)
            {
                ls.Add(new ePhieuNhapKho( pn.sopdnn, pn.manhanvien, pn.makho, pn.ngaylap));
            }
            return ls;
        }

        public List<ePhieuNhapKho> getpnktheoma(string ma)
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach(PhieuNhapKho pn in db.PhieuNhapKhos.Where(p => p.sopdnn == ma))
            {
                ls.Add(new ePhieuNhapKho(pn.sopdnn, pn.manhanvien, pn.makho, pn.ngaylap));
            }
            return ls;
        }

        public List<SanPham> getSPtheosoPDNN(string maphieu)
        {
            PhieuNhapKho pnk = db.PhieuNhapKhos.Where(e => e.sopdnn == maphieu).FirstOrDefault();
            List<SanPham> l = new List<SanPham>();
            foreach (ChiTietPhieuDNNK ct in pnk.PhieuDNNK.ChiTietPhieuDNNKs)
            {
                SanPham sp = db.SanPhams.Where(e => e.MaSP == ct.MaSP).FirstOrDefault();
                l.Add(sp);
            }
            return l;
        }

        private bool ktraTonTai(string soPhieu)
        {
            PhieuDNNK p = db.PhieuDNNKs.Where(pdn => pdn.MaPhieuDNNK == soPhieu).FirstOrDefault();
            if(p!=null)
            {
                return false;
            }
            return true;
        }

        public int taophieunhapkho(ePhieuNhapKho pnk)
        {
            if (ktraTonTai(pnk.SoPDNN))
                return 0;

            PhieuNhapKho pn = new PhieuNhapKho();
            pn.sopdnn = pnk.SoPDNN;
            pn.manhanvien = pnk.MaNV;
            pn.makho = pnk.MaKho;
            pn.ngaylap = pnk.NgayLap;

            db.PhieuNhapKhos.InsertOnSubmit(pn);
            db.SubmitChanges();
            return 1;
        }
    }
}
