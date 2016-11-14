using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;
using BusinessEntities.NhanSu;
namespace DataAccessLayer.PhongKeHoach.SanPhamLap
{
    public class SanPham_DAL
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
        public List<eLoaiSanPham> GetalloaiSp()
        {
            var c = from i in db.LoaiSanPhams
                    select i;
            List<eLoaiSanPham> ls = new List<eLoaiSanPham>();
            foreach (LoaiSanPham e in c.ToList())
            {
                eLoaiSanPham newe = new eLoaiSanPham();
                newe.MaLoaiSP = e.MaLoaiSanPham;
                newe.TenLoaiSP = e.TenLoaiSanPham;
                newe.Style = e.Style;
                newe.MoTa = e.Mota;
                ls.Add(newe);
            }
            return ls;
        }
        public List<eSanPham> GetAllSpCanUpdateThongTin()
        {
            List<eSanPham> ls = new List<eSanPham>();
            foreach (LoaiSanPham e in db.LoaiSanPhams.ToList())
            {
                var c = from i in db.SanPhams
                        where i.MaLoaiSanPham != e.MaLoaiSanPham
                        select i;

                foreach (SanPham sp in c.ToList())
                {
                    eSanPham esp = new eSanPham();
                    esp.MaLoaiSP = sp.MaLoaiSanPham;
                    esp.TenSP = sp.TenSp;
                    esp.KieuDang = sp.KieuDang;
                    esp.NgaySX = Convert.ToDateTime(sp.NgaySanXuat);
                    esp.NgayHetHan = Convert.ToDateTime(sp.NgayHetHan);
                    esp.MauSac = sp.MauSac;
                    esp.MaLoaiSP = sp.MaLoaiSanPham;
                    esp.Trongluong = Convert.ToDouble(sp.TrongLuong);
                    esp.DonViTinh = sp.DonViTinh;
                    esp.MoTa = sp.Mota;
                    ls.Add(esp);
                }
            } return ls;
        }
        public List<eSanPham> GetAllSpByMaSP(string Masp)
        {

            var c = from i in db.SanPhams
                    where i.MaSP == Masp
                    select i;
            List<eSanPham> ls = new List<eSanPham>();
            foreach (SanPham sp in c.ToList())
            {
                eSanPham esp = new eSanPham();
                esp.MaLoaiSP = sp.MaLoaiSanPham;
                esp.TenSP = sp.TenSp;
                esp.KieuDang = sp.KieuDang;
                esp.NgaySX = Convert.ToDateTime(sp.NgaySanXuat);
                esp.NgayHetHan = Convert.ToDateTime(sp.NgayHetHan);
                esp.MauSac = sp.MauSac;
                esp.MaLoaiSP = sp.MaLoaiSanPham;
                esp.Trongluong = Convert.ToDouble(sp.TrongLuong);
                esp.DonViTinh = sp.DonViTinh;
                esp.MoTa = sp.Mota;
                ls.Add(esp);
            }
            return ls;
        }
        public decimal GiaBanSi(string masp)
        {
            BangGiaBanSi gia = db.BangGiaBanSis.Where(x => x.maSP == masp).FirstOrDefault();
            return Convert.ToDecimal(gia.giaBan);
        }
        public void CapNhatLaiThongTinSP(string masp, string maloaisp, string kieudang, string donvitinh, string mausac, string mota, DateTime ngaysanxuat, DateTime ngayhethan, decimal trongluong)
        {
            SanPham sp = db.SanPhams.Where(x => x.MaSP == masp).FirstOrDefault();
            sp.MaLoaiSanPham = maloaisp;
            sp.KieuDang = kieudang;
            sp.DonViTinh = donvitinh;
            sp.MaLoaiSanPham = mausac;
            sp.Mota = mota;
            sp.NgaySanXuat = ngaysanxuat;
            sp.NgayHetHan = ngayhethan;
            sp.TrongLuong = Convert.ToDouble(trongluong);
            db.SubmitChanges();
        }
        public bool themLoaisp(eLoaiSanPham loai)
        {
            var c = from i in db.LoaiSanPhams
                    where i.MaLoaiSanPham == loai.MaLoaiSP
                    select i;
            if(c.Any())
            {
                throw new Exception("There Already Have");
            }
            else
            {
                LoaiSanPham l = new LoaiSanPham();
                l.MaLoaiSanPham = loai.MaLoaiSP;
                l.TenLoaiSanPham = loai.TenLoaiSP;
                l.Style = loai.Style;
                l.Mota = loai.MoTa;
                db.LoaiSanPhams.InsertOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
        }
    }
}

