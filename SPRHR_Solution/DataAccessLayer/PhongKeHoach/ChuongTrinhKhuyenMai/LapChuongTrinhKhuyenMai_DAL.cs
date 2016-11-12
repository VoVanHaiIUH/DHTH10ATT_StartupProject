using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.KhuyenMai
{
    class LapChuongTrinhKhuyenMai_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongCT(string MaCt)
        {
            ChuongTrinhKhuyenMai Ctrinh = db.ChuongTrinhKhuyenMais.Where(x => x.MaCT == MaCt).FirstOrDefault();
            if (Ctrinh != null)
            {
                return true;
            }
            else
            {
                throw new Exception("Invaild ID");
            }
        }
        public int CountSlCT()
        {
            int n = db.ChuongTrinhKhuyenMais.Count();
            return n;
        }
        public int CountSLChiTietByMa(string Ma)
        {
            int n = db.ChiTietKhuyenMais.Where(x => x.MaCT == Ma).Count();
            return n;
        }
        public List<eChuongTrinhKhuyenMai> GetALLChuongTrinhKhuyenMai()
        {
            var ChuongTrinh = from i in db.ChuongTrinhKhuyenMais
                              select i;
            List<eChuongTrinhKhuyenMai> Ls = new List<eChuongTrinhKhuyenMai>();
            foreach (ChuongTrinhKhuyenMai ct in ChuongTrinh.ToList())
            {
                eChuongTrinhKhuyenMai newCt = new eChuongTrinhKhuyenMai();
                newCt.MaCT = TaoMaChuongTrinhKhuyenMai();
                newCt.TenCT = ct.TenCT;
                newCt.NgayKhoiDong = DateTime.Now;
                newCt.NgayKetThuc = (DateTime)ct.NgayKetThuc;
                newCt.MoTa = ct.MoTa;
                Ls.Add(newCt);
            }
            return Ls;
        }
        public List<eChuongTrinhKhuyenMai> GetALLChuongTrinhKhuyenMaiConTonTai()
        {
            var ChuongTrinh = from i in db.ChuongTrinhKhuyenMais
                              where DateTime.Now <= i.NgayKetThuc
                              select i;
            List<eChuongTrinhKhuyenMai> Ls = new List<eChuongTrinhKhuyenMai>();
            foreach (ChuongTrinhKhuyenMai ct in ChuongTrinh.ToList())
            {
                eChuongTrinhKhuyenMai newCt = new eChuongTrinhKhuyenMai();
                newCt.MaCT = TaoMaChuongTrinhKhuyenMai();
                newCt.TenCT = ct.TenCT;
                newCt.NgayKhoiDong = DateTime.Now;
                newCt.NgayKetThuc = (DateTime)ct.NgayKetThuc;
                newCt.MoTa = ct.MoTa;
                Ls.Add(newCt);
            }
            return Ls;
        }

        public List<eChuongTrinhKhuyenMai> GetALLChuongTrinhKhuyenMaiHetHan()
        {
            var ChuongTrinh = from i in db.ChuongTrinhKhuyenMais
                              where DateTime.Now > i.NgayKetThuc
                              select i;
            List<eChuongTrinhKhuyenMai> Ls = new List<eChuongTrinhKhuyenMai>();
            foreach (ChuongTrinhKhuyenMai ct in ChuongTrinh.ToList())
            {
                eChuongTrinhKhuyenMai newCt = new eChuongTrinhKhuyenMai();
                newCt.MaCT = TaoMaChuongTrinhKhuyenMai();
                newCt.TenCT = ct.TenCT;
                newCt.NgayKhoiDong = DateTime.Now;
                newCt.NgayKetThuc = ct.NgayKetThuc;
                newCt.MoTa = ct.MoTa;
                Ls.Add(newCt);
            }
            return Ls;
        }
        public List<eChiTietChuongTrinhKhuyenMai> GetALLChitietKhuyenMaiByMaCT(string Ma)
        {
            var Chitiet = from i in db.ChiTietKhuyenMais
                          where i.MaCT == Ma
                          select i;
            List<eChiTietChuongTrinhKhuyenMai> Ls = new List<eChiTietChuongTrinhKhuyenMai>();
            foreach (ChiTietKhuyenMai Ct in Chitiet.ToList())
            {
                eChiTietChuongTrinhKhuyenMai newCt = new eChiTietChuongTrinhKhuyenMai();
                newCt.MaCT = Ct.MaCT;
                newCt.MaSP = Ct.MaSp;
                newCt.MucGiam = Convert.ToDouble(Ct.MucGiam);
                newCt.DonGia = Convert.ToDouble(Ct.DonGia);
                newCt.GiaKhuyenMai = Convert.ToDouble(Ct.GiaKhuyenMai);
                Ls.Add(newCt);
            }
            return Ls;
        }
        public int InsertChiTietHoaDon(eChiTietChuongTrinhKhuyenMai Ctiet)
        {
            var Sanpham = from i in db.SanPhams
                          where i.MaSP == Ctiet.MaSP
                          select i;
            if (Sanpham.Any())
            {
                var Chitiet = from i in db.ChiTietKhuyenMais
                              where i.MaCT == Ctiet.MaCT && i.MaSp == Ctiet.MaSP
                              select i;
                if (Chitiet.Any())
                {
                    throw new Exception("There Already Have");
                }
                else
                {
                    ChiTietKhuyenMai Ct = new ChiTietKhuyenMai();
                    Ct.MaCT = Ctiet.MaCT;
                    Ct.MaSp = Ctiet.MaSP;
                    Ct.DonGia = Convert.ToDecimal(Ctiet.DonGia);
                    Ct.MucGiam = Ctiet.MucGiam;
                    Ct.GiaKhuyenMai = Convert.ToDecimal(Ctiet.GiaKhuyenMai);
                    db.ChiTietKhuyenMais.InsertOnSubmit(Ct);
                    db.SubmitChanges();
                    return 1;
                }
            }
            else
            {
                throw new Exception("Invaild SanPham");
            }
        }
        public bool DeleteCtKhuyenMai(string Ma)
        {
            var ct = from i in db.ChiTietKhuyenMais
                     where i.MaCT == Ma
                     select i;
            if (ct.Any())
            {
                throw new Exception("This Can't Be Delete");
            }
            else
            {
                ChuongTrinhKhuyenMai ChuongTrinh = db.ChuongTrinhKhuyenMais.Where(x => x.MaCT == Ma).FirstOrDefault();
                if (ChuongTrinh != null)
                {
                    db.ChuongTrinhKhuyenMais.DeleteOnSubmit(ChuongTrinh);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Invaild ID");
                }
            }
        }
        public bool DeleteTungChitietKhuyenMai(string Ma, string Masp)
        {
            ChiTietKhuyenMai ctiet = db.ChiTietKhuyenMais.Where(x => x.MaCT == Ma && x.MaSp == Masp).FirstOrDefault();
            if (ctiet != null)
            {
                db.ChiTietKhuyenMais.DeleteOnSubmit(ctiet);
                db.SubmitChanges();
                return true;
            }
            else
            {
                throw new Exception("Invalid Details");
            }
        }
        public bool DeleteHetChitiet(string Ma)
        {
            var c = from i in db.ChiTietKhuyenMais
                    where i.MaCT == Ma
                    select i;
            if (c.Any())
            {
                foreach (ChiTietKhuyenMai ct in c.ToList())
                {
                    db.ChiTietKhuyenMais.DeleteOnSubmit(ct);
                    db.SubmitChanges();
                }
                return true;
            }
            else
            {
                throw new Exception("Invalid Details For ID");
            }
        }
        private string TaoMaChuongTrinhKhuyenMai()
        {
            int max = 0;
            foreach (ChuongTrinhKhuyenMai Ct in db.ChuongTrinhKhuyenMais)
            {
                int t = int.Parse(Ct.MaCT.Substring(4));
                if (t >= max)
                    max = t;
            }
            max++;
            return "CTKM" + string.Format("{0:0000}", max);
        }
        public void SureDeleCTKM(string MaCt)
        {
            DeleteHetChitiet(MaCt);
            DeleteCtKhuyenMai(MaCt);
        }
    }
}
