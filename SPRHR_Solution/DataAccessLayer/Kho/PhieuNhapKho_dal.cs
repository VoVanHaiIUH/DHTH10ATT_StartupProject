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
        private void getSPtheosoPDNN(string maphieu)
        {
            PhieuNhapKho pnk = db.PhieuNhapKhos.Where(e => e.sopdnn == maphieu).FirstOrDefault();
            List<SanPham> l = new List<SanPham>();
            foreach (ChiTietPhieuDNNK ct in pnk.PhieuDNNK.ChiTietPhieuDNNKs)
            {
                SanPham sp = db.SanPhams.Where(e => e.MaSP == ct.MaSP).FirstOrDefault();
                l.Add(sp);
            }
        }
        public void taophieunhapkho(string manv, string sopdnnk, string makho, DateTime ngaylap)
        {
            PhieuNhapKho pn = new PhieuNhapKho();
            pn.sopdnn = sopdnnk;
            pn.manhanvien = manv;
            pn.makho = makho;
            pn.ngaylap = ngaylap;

            db.PhieuNhapKhos.InsertOnSubmit(pn);
            db.SubmitChanges();
        }
    }
}
