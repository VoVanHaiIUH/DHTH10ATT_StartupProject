﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.PhieuDeNghiXuatKho
{
    public class LapPhieuDeNghiXuatKho_DAL
    {
        //Check Co Khong PDNXK
        //Get ALL PDNXK
        //Get ALL PDNXK By Ma
        //Get ALL Chi Tiet PDNXK
        //Count PDNXK
        //Count Chi Tiet Cua Mot Phieu De Nghi Xuat Kho
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongPhieuDNXK(string SoPhieu)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaPhieuDNXK == SoPhieu
                    select i;
            if(c.Any())
            {
                return true;
            }
            throw new Exception("Invaild PDNXK");
        }
        
        public List<ePhieuDeNghiXuatKho> GetALLPDNXK()
        {
            var c = from i in db.PhieuDNXKs
                    select i;
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach(PhieuDNXK Phieu in c.ToList())
            {
                ePhieuDeNghiXuatKho XK = new ePhieuDeNghiXuatKho();
                XK.SoPhieuDeNghiXuatKho = Phieu.MaPhieuDNXK;
                XK.MaNhanVien = Phieu.MaNhanVien;
                XK.MaKH = Phieu.MaKH;
                XK.MaKho = Phieu.MaKho;
                XK.NgayLap = Phieu.NgayLap;
                XK.TinhTrang = Phieu.tinhtrang;
                ls.Add(XK);
            }
            return ls;
        }
        //Get ALL PDNXK by NhanVien,By KhachHang,By Kho ...... pending
        public List<ePhieuDeNghiXuatKho> GetPDNXKByMa(String SoPhieu)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaPhieuDNXK == SoPhieu
                    select i;
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK Phieu in c.ToList())
            {
                ePhieuDeNghiXuatKho XK = new ePhieuDeNghiXuatKho();
                XK.SoPhieuDeNghiXuatKho = Phieu.MaPhieuDNXK;
                XK.MaNhanVien = Phieu.MaNhanVien;
                XK.MaKH = Phieu.MaKH;
                XK.MaKho = Phieu.MaKho;
                XK.NgayLap = Phieu.NgayLap;
                XK.TinhTrang = Phieu.tinhtrang;
                ls.Add(XK);
            }
            return ls;
        }

        public List<ePhieuDeNghiXuatKho> GetPDNXKByMaNhanVien(string MaNhanVien)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaNhanVien == MaNhanVien
                    select i;
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK Phieu in c.ToList())
            {
                ePhieuDeNghiXuatKho XK = new ePhieuDeNghiXuatKho();
                XK.SoPhieuDeNghiXuatKho = Phieu.MaPhieuDNXK;
                XK.MaNhanVien = Phieu.MaNhanVien;
                XK.MaKH = Phieu.MaKH;
                XK.MaKho = Phieu.MaKho;
                XK.NgayLap = Phieu.NgayLap;
                XK.TinhTrang = Phieu.tinhtrang;
                ls.Add(XK);
            }
            return ls;
        }

        public List<ePhieuDeNghiXuatKho> GetPDNXKByMaKho(string MaKho)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaKho == MaKho
                    select i;
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK Phieu in c.ToList())
            {
                ePhieuDeNghiXuatKho XK = new ePhieuDeNghiXuatKho();
                XK.SoPhieuDeNghiXuatKho = Phieu.MaPhieuDNXK;
                XK.MaNhanVien = Phieu.MaNhanVien;
                XK.MaKH = Phieu.MaKH;
                XK.MaKho = Phieu.MaKho;
                XK.NgayLap = Phieu.NgayLap;
                XK.TinhTrang = Phieu.tinhtrang;
                ls.Add(XK);
            }
            return ls;
        }

        public List<ePhieuDeNghiXuatKho> GetPDNXKByMaKH(string MaKhachhang)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaKH == MaKhachhang
                    select i;
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK Phieu in c.ToList())
            {
                ePhieuDeNghiXuatKho XK = new ePhieuDeNghiXuatKho();
                XK.SoPhieuDeNghiXuatKho = Phieu.MaPhieuDNXK;
                XK.MaNhanVien = Phieu.MaNhanVien;
                XK.MaKH = Phieu.MaKH;
                XK.MaKho = Phieu.MaKho;
                XK.NgayLap = Phieu.NgayLap;
                XK.TinhTrang = Phieu.tinhtrang;
                ls.Add(XK);
            }
            return ls;
        }

        public List<eChiTietPhieuDeNghiXuatKho> GetALLChitietPDNXKByMa(string SoPhieu)
        {
            var c = from i in db.ChiTietPhieuDNXKs
                    where i.MaPhieuDNXK == SoPhieu
                    select i;
            List<eChiTietPhieuDeNghiXuatKho> ls = new List<eChiTietPhieuDeNghiXuatKho>();
            foreach(ChiTietPhieuDNXK CT in c.ToList())
            {
                eChiTietPhieuDeNghiXuatKho ct = new eChiTietPhieuDeNghiXuatKho();
                ct.SoPhieu = CT.MaPhieuDNXK;
                ct.MaSP = CT.MaSP;
                ct.SoLuong = CT.SoLuong;
                ct.GhiChu = CT.GhiChu;
                ls.Add(ct);
            }
            return ls;
        }

        public int CountSoLuongPDNXK(int n)
        {
            List<ePhieuDeNghiXuatKho> ls = GetALLPDNXK();
            n = ls.Count();
            return n;
        }

        public int CountSoLuongChiTietPDNXKBySoPhieu(string SoPhieu, int n)
        {
            List<eChiTietPhieuDeNghiXuatKho> ls = GetALLChitietPDNXKByMa(SoPhieu);
            n = ls.Count();
            return n;
        }
        // Tao PDNXK
        // Tao chi tiet PDNXK
        // Delete PDNXK
        // Delete chi tiet PDNXK
        // ....
        // ....
        //.........>>
        public void InsertPDNXK(ePhieuDeNghiXuatKho Phieu)
        {
            Phieu.NgayLap = DateTime.Now;
            PhieuDNXK NewPhieu = new PhieuDNXK();
            NewPhieu.MaPhieuDNXK = TaoMaPDNXK();
            NewPhieu.MaKH = Phieu.MaKH;
            NewPhieu.MaKho = Phieu.MaKho;
            NewPhieu.MaNhanVien = Phieu.MaNhanVien;
            NewPhieu.NgayLap = Phieu.NgayLap;
            NewPhieu.tinhtrang = Convert.ToInt32(Phieu.TinhTrang);
            db.PhieuDNXKs.InsertOnSubmit(NewPhieu);
            db.SubmitChanges();
        }

        public int InsertPDNXKChiTiet(eChiTietPhieuDeNghiXuatKho Chitiet)
        {
            var sp = from i in db.SanPhams
                     where i.MaSP == Chitiet.MaSP
                     select i;
            if (sp.Any())
            {
                var c = from i in db.ChiTietPhieuDNXKs
                        where i.MaSP == Chitiet.MaSP && i.MaPhieuDNXK == Chitiet.SoPhieu
                        select i;
                if (c.Any())
                {
                    return 0;
                    throw new Exception("There have already");
                }
                else
                {
                    ChiTietPhieuDNXK newct = new ChiTietPhieuDNXK();
                    newct.MaPhieuDNXK = Chitiet.SoPhieu;
                    newct.MaSP = Chitiet.MaSP;
                    newct.GhiChu = Chitiet.GhiChu;
                    newct.SoLuong = Chitiet.SoLuong;
                    db.ChiTietPhieuDNXKs.InsertOnSubmit(newct);
                    db.SubmitChanges();
                    return 1;
                }
            }
            else
            {
                return 2;
                throw new Exception("Invaild SanPham");
            }
        }

        public bool DeLetePDNXK(string SoPhieu)
        {
            var c = from i in db.PhieuXuatKhos
                    where i.soPXK == SoPhieu
                    select i;
            if(c.Any())
            {
                throw new Exception("This Can't Be Delete");
            }
            else
            {
                PhieuDNXK phieu = db.PhieuDNXKs.Where(x => x.MaPhieuDNXK == SoPhieu).FirstOrDefault();
                if (phieu != null)
                {
                    db.PhieuDNXKs.DeleteOnSubmit(phieu);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Invalid ID");
                }
            }
        }

        public void DeletePDNXKChiTiet(string SoPhieu, string MaSP)
        {
            ChiTietPhieuDNXK chitiet = db.ChiTietPhieuDNXKs.Where(x => x.MaPhieuDNXK == SoPhieu && x.MaSP == MaSP).FirstOrDefault();
            if (chitiet != null)
            {
                db.ChiTietPhieuDNXKs.DeleteOnSubmit(chitiet);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Invald Details");
            }
        }

        private string TaoMaPDNXK()
        {
            int max = 0;
            foreach (PhieuDNXK Phieu in db.PhieuDNXKs)
            {
                int t = int.Parse(Phieu.MaPhieuDNXK.Substring(5));
                if (t >= max)
                    max = t;
            }
            max++;
            return "PDNXK" + string.Format("{0:0000}", max);
        }
    }
}
