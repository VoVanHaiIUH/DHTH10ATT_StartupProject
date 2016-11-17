using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;
using BusinessEntities.NhanSu;
namespace DataAccessLayer.Kho
{
    public class QuanLyKho_dal
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();

        public List<eThongTinKho> GetKho()
        {
            List<eThongTinKho> eql = new List<eThongTinKho>();
            foreach (ThongTinKho ql in db.ThongTinKhos)
            {
                eThongTinKho t = new eThongTinKho();
                t.MaKho = ql.maKho;
                t.TenKho = ql.tenKho;
                eql.Add(t);

            }
            return eql;
        }

        public List<eChucVu> GetChucVu()
        {
            List<eChucVu> c = new List<eChucVu>();
            foreach (ChucVu cv in db.ChucVus)
            {
                c.Add(new eChucVu(cv.maChucVu,cv.tenChucVU,cv.moTa));
            }
            return c;
        }
        public List<eChucVu> GetChucVubyMa(string ma)
        {
            List<eChucVu> cv = new List<eChucVu>();
            foreach (ChucVu c in db.ChucVus.Where(e => e.maChucVu == ma))
            {
                cv.Add(new eChucVu(c.maChucVu, c.tenChucVU, c.moTa));
            }
            return cv;
        }
        //private bool ClosestDate(DateTime date)
        //{
        //    foreach(QuanLyKho ql in db.QuanLyKhos.Where(e=>e.thoiGianBatDau == date))
        //    {

        //    }
        //    return false;
        //}
        public List<eQuanLyKho> GetNv(string ma)
        {
            List<eQuanLyKho> eql = new List<eQuanLyKho>();
            foreach (QuanLyKho ql in db.QuanLyKhos.Where(e => e.maKho == ma && e.thoiGianKetThuc == null))
            {
                eQuanLyKho t = new eQuanLyKho();
                t.MaNV = ql.manhanvien;
                t.ChucVu = ql.chucVu;
                t.MaKho = ql.maKho;

                eql.Add(t);

            }
            return eql;
        }

        public List<eNhanVien> GetTTNhanVien(string manv)
        {
            List<eNhanVien> ls = new List<eNhanVien>();
            foreach(NhanVien nv in db.NhanViens.Where(n=>n.maNhanVien == manv))
            {
                eNhanVien t = new eNhanVien();
                t.HoTenNhanVien = nv.hoTenNhanVien;
                t.SoDT = nv.soDT;
                ls.Add(t);
            }
            return ls;
        }

        private bool KtraTinhTrangNV(string manv)
        {
            NhanVien nv = db.NhanViens.Where(n => n.maNhanVien == manv).FirstOrDefault();
            if (nv == null || nv.tinhTrang == "Nghi Viec")
                return true;
            return false;
        }

        private bool KtraNv(string manv, string makho)
        {
            QuanLyKho ql = db.QuanLyKhos.Where(n => n.manhanvien == manv && n.maKho == makho).FirstOrDefault();
            if (ql != null)
            {
                if (ql.thoiGianKetThuc == DateTime.Now)
                    throw new Exception("Hiện tại không thể thêm nhân viên này");
                if(ql.thoiGianKetThuc == null)
                    return true;
            }
            return false;
        }

        public int TaoNvKho(eQuanLyKho ql)
        {
            if (KtraTinhTrangNV(ql.MaNV))
                throw new Exception("Nhân viên đã nghỉ hoặc không có nhân viên này");
            if (KtraNv(ql.MaNV,ql.MaKho))
                throw new Exception("Nhân viên này đang làm ở kho " + ql.MaKho);
            if (ql.ChucVu == "")
                throw new Exception("Chức vụ không thể trống");
            QuanLyKho eql = new QuanLyKho();
            eql.maKho = ql.MaKho;
            eql.manhanvien = ql.MaNV.ToUpper();
            eql.chucVu = ql.ChucVu.ToUpper();
            eql.thoiGianBatDau = DateTime.Now;
            db.QuanLyKhos.InsertOnSubmit(eql);
            db.SubmitChanges();
            return 1;
        }

        public bool XoaNVKho(string manv, string makho)
        {
            QuanLyKho ql = db.QuanLyKhos.Where(n => n.manhanvien == manv && n.maKho == makho && n.thoiGianKetThuc==null).FirstOrDefault();
            if(ql!=null)
            {
                ql.thoiGianKetThuc = DateTime.Now;//không xóa nhân viên này, chỉ cập nhật ngày đã nghỉ việc

                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void SuaThongtinNvKho(eQuanLyKho update)
        {
            if (update.ChucVu == "")
                throw new Exception("Chức vụ không thể trống");
            QuanLyKho ql = new QuanLyKho();
            ql.maKho = update.MaKho;
            ql.manhanvien = update.MaNV.ToUpper();
            ql.chucVu = update.ChucVu.ToUpper();
            ql.thoiGianBatDau = DateTime.Now;

            db.QuanLyKhos.InsertOnSubmit(ql);//tạo nhân viên mới với 1 chức vụ khác, chức vụ cũ của nhân viên này không bị ghi đè lên
            db.SubmitChanges();


        }
    }
}
