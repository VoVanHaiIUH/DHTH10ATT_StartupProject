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
        public List<ePhieuNhapKho> getdspnk()
        {
            List<ePhieuNhapKho> ls = new List<ePhieuNhapKho>();
            foreach(PhieuNhapKho pn in db.PhieuNhapKhos)
            {
                ls.Add(new ePhieuNhapKho(pn.sopnk, pn.sopdnn, pn.manhanvien, pn.makho, pn.ngaylap));
            }
            return ls;
        }
        private string taosoPNK()
        {
            int max = 0;
            foreach(PhieuNhapKho pnk in db.PhieuNhapKhos)
            {
                int t = int.Parse(pnk.sopnk.Substring(3));
                if (t >= max)
                    max = t;
            }
            max++;
            return "PNK" + string.Format("{0:0000}", max);
        }
        public void taophieunhapkho(string manv, string sopdnnk, string makho, DateTime ngaylap)
        {
            PhieuNhapKho pn = new PhieuNhapKho();
            pn.sopnk = taosoPNK();
            pn.sopnk = sopdnnk;
            pn.manhanvien = manv;
            pn.makho = makho;
            pn.ngaylap = ngaylap;

            db.PhieuNhapKhos.InsertOnSubmit(pn);
            db.SubmitChanges();
        }
    }
}
