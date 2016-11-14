﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using BusinessEntities.NhanSu;
namespace DataAccessLayer.PhongKeHoach.SanPhamLap
{
    class SanPham_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public List<eSanPham> GetALLSanPham()
        {
            var c = from x in db.SanPhams
                    select x;
            List<eSanPham> ls = new List<eSanPham>();
            foreach (SanPham s in c.ToList())
            {
                ls.Add(new eSanPham(s.MaSP, s.TenSp, (double)s.TrongLuong, (DateTime)s.NgaySanXuat, s.Mota, s.DonViTinh, s.KieuDang, s.MaLoaiSanPham, s.MauSac, (DateTime)s.NgayHetHan));

            }
            return ls;
        }
        public List<eNhaCungCap> GetAllNhaCC()
        {
            var q = from x in db.NhaCungCaps
                    select x;
            List<eNhaCungCap> ls = new List<eNhaCungCap>();
            foreach (NhaCungCap a in q.ToList())
            {
                ls.Add(new eNhaCungCap(a.DiaChi, a.MaNhaCungCap, a.TenNhaCungCap, (int)a.Phone));
            }
            return ls;
        }
        public void InsertNhaCC(eNhaCungCap a)
        {
            NhaCungCap e = new NhaCungCap();
            e.MaNhaCungCap = TaoMaNhaCC();
            e.TenNhaCungCap = a.TenNCC;
            e.Phone = a.Phone;
            e.DiaChi = a.DiaChi;
            e.NgayThanhLap = null;
            db.NhaCungCaps.InsertOnSubmit(e);
            db.SubmitChanges();
        }
        private string TaoMaNhaCC()
        {
            int max = 0;
            foreach (NhaCungCap nha in db.NhaCungCaps)
            {
                int t = int.Parse(nha.MaNhaCungCap.Substring(3));
                if (t >= max)
                    max = t;
            }
            max++;
            return "NCC" + string.Format("{0:0000}", max);
        }
        public List<eNhanVien> GetAllNhanVien()
        {
            var q = from x in db.NhanViens
                    select x;
            List<eNhanVien> ls = new List<eNhanVien>();
            foreach (NhanVien a in q.ToList())
            {
                ls.Add(new eNhanVien(a.maNhanVien, a.hoTenNhanVien, (DateTime)a.ngayBatDauLamViec, a.tinhTrang, a.soTKNganHang, a.soDT, a.queQuan, a.Email, a.soCMND, a.diaChi, a.gioiTinh, (DateTime)a.ngaySinh));
            }
            return ls;
        }

    }
}