using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
namespace BLL
{
    public class PhieuDNXKBLL
    {
        QuanLyDataMessageDataContext db;
        public PhieuDNXKBLL()
        {
            db = new QuanLyDataMessageDataContext();
        }
        public List<ePhieuDNXK> GetAllPhieuDNXK()
        {
            List<ePhieuDNXK> lst = new List<ePhieuDNXK>();
            foreach (PhieuDNXK pdnxk in db.PhieuDNXKs.Where(n=>n.tinhtrang == 0).ToList())
            {
                lst.Add(new ePhieuDNXK() { MaKH = pdnxk.MaKH, MaKho = pdnxk.MaKho, MaNhanVien = pdnxk.MaNhanVien, MaPhieuDNXK = pdnxk.MaPhieuDNXK, NgayLap = pdnxk.NgayLap });
            }
            return lst;
        }
        public int InsertPhieuDNXK(ePhieuDNXK pdnxkNew)
        {
            var pdnxk = db.PhieuDNXKs.Where(n => n.MaPhieuDNXK == pdnxkNew.MaPhieuDNXK).FirstOrDefault();
            if (pdnxk != null)
                return 0;
            else
            {
                pdnxk = new PhieuDNXK() { MaKH = pdnxkNew.MaKH, MaKho = pdnxkNew.MaKho, MaNhanVien = pdnxkNew.MaNhanVien, MaPhieuDNXK = pdnxkNew.MaPhieuDNXK, NgayLap = pdnxkNew.NgayLap };
                try
                {
                    db.PhieuDNXKs.InsertOnSubmit(pdnxk);
                    db.SubmitChanges();
                    return 1;
                }
                catch
                {
                    try
                    {
                        db.PhieuDNXKs.DeleteOnSubmit(pdnxk);
                    }
                    catch
                    { }
                    return 0;
                }
            }
        }
        public bool UpdatePhieuDNXK(string pMaPhieuDNXK)
        {
            var MaPhieuDNXK = db.PhieuDNXKs.Where(n => n.MaPhieuDNXK == pMaPhieuDNXK).FirstOrDefault();
            if (MaPhieuDNXK != null)
            {
                MaPhieuDNXK.tinhtrang = 1;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
