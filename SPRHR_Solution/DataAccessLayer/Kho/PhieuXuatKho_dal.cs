using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;

namespace DataAccessLayer.Kho
{
    public class PhieuXuatKho_dal
    {
        SPRHR_SolutionDataContext db;
        public PhieuXuatKho_dal()
        {
            db = new SPRHR_SolutionDataContext();
        }
        //public List<ePhieuXuatKho> getdspnk()
        //{
        //    List<ePhieuXuatKho> ls = new List<ePhieuXuatKho>();
        //    foreach (PhieuXuatKho px in db.PhieuXuatKhos)
        //    {
        //        ls.Add(new ePhieuXuatKho(px.soPXK,px.s,px.manhanvien,px.makho,px.ngaylap));
        //    }
        //    return ls;
        //}
        //private string taosoPNK()
        //{
        //    int max = 0;
        //    foreach (PhieuXuatKho pxk in db.PhieuXuatKhos)
        //    {
        //        int t = int.Parse(pxk.soPXK.Substring(3));
        //        if (t >= max)
        //            max = t;
        //    }
        //    max++;
        //    return "PNK" + string.Format("{0:0000}", max);
        //}
        //public void taophieunhapkho(string manv, string sopdnnk, string makho, DateTime ngaylap)
        //{
        //    pheiu pn = new PhieuNhapKho();
        //    pn.sopnk = taosoPNK();
        //    pn.sopnk = sopdnnk;
        //    pn.manhanvien = manv;
        //    pn.makho = makho;
        //    pn.ngaylap = ngaylap;

        //    db.PhieuNhapKhos.InsertOnSubmit(pn);
        //    db.SubmitChanges();
        //}
    }
}
