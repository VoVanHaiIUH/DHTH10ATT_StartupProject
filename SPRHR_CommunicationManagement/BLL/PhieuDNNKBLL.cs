using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class PhieuDNNKBLL
    {
        QuanLyDataMessageDataContext db;
        public PhieuDNNKBLL()
        {
            db = new QuanLyDataMessageDataContext();
        }
        public List<ePhieuDNNK> GetAllPhieuDNNK()
        {
            List<ePhieuDNNK> lst = new List<ePhieuDNNK>();
            foreach (PhieuDNNK pdnnk in db.PhieuDNNKs.Where(n => n.tinhtrang == 0).ToList())
            {
                lst.Add(new ePhieuDNNK() { MaKho = pdnnk.MaKho,MaNhanVien = pdnnk.MaNhanVien,MaPhieuDNNK = pdnnk.MaPhieuDNNK,MoTa = pdnnk.MoTa,NgayLap = pdnnk.NgayLap});
            }
            return lst;
        }
        public int InsertPhieuDNNK(ePhieuDNNK pdnnkNew)
        {
            var pdnnk = db.PhieuDNNKs.Where(n => n.MaPhieuDNNK == pdnnkNew.MaPhieuDNNK).FirstOrDefault();
            if (pdnnk != null)
                return 0;
            else
            {
                pdnnk = new PhieuDNNK() { MaKho = pdnnkNew.MaKho, MaNhanVien = pdnnkNew.MaNhanVien, MaPhieuDNNK = pdnnkNew.MaPhieuDNNK, MoTa = pdnnkNew.MoTa, NgayLap = pdnnkNew.NgayLap };
                try
                {
                    db.PhieuDNNKs.InsertOnSubmit(pdnnk);
                    db.SubmitChanges();
                    return 1;
                }
                catch
                {
                    try
                    {
                        db.PhieuDNNKs.DeleteOnSubmit(pdnnk);
                    }
                    catch
                    { }
                    return 0;
                }
            }
        }
        public bool UpdatePhieuDNNK(string pMaPhieuDNNK)
        {
            var MaPhieuDNNK = db.PhieuDNNKs.Where(n => n.MaPhieuDNNK == pMaPhieuDNNK).FirstOrDefault();
            if (MaPhieuDNNK != null)
            {
                MaPhieuDNNK.tinhtrang = 1;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
