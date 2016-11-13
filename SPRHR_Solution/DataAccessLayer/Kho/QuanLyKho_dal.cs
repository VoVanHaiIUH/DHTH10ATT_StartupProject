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

        public List<eQuanLyKho> GetNv(string ma)
        {
            List<eQuanLyKho> eql = new List<eQuanLyKho>();
            foreach(QuanLyKho ql in db.QuanLyKhos.Where(e=>e.maKho == ma))
            {
                eql.Add(new eQuanLyKho(ql.maKho, ql.manhanvien, ql.chucVu));
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

        public int TaoNvKho(eQuanLyKho ql)
        {
            if (KtraTinhTrangNV(ql.MaNV))
                return 0;
            QuanLyKho eql = new QuanLyKho();
            eql.maKho = ql.MaKho;
            eql.manhanvien = ql.MaNV;
            eql.chucVu = ql.ChucVu;

            db.QuanLyKhos.InsertOnSubmit(eql);
            db.SubmitChanges();
            return 1;
        }

        public bool XoaNVKho(string manv, string makho)
        {
            QuanLyKho ql = db.QuanLyKhos.Where(n => n.manhanvien == manv && n.maKho == makho).FirstOrDefault();
            if(ql!=null)
            {
                db.QuanLyKhos.DeleteOnSubmit(ql);
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void SuaThongtinNvKho(eQuanLyKho update)
        {
            QuanLyKho p = db.QuanLyKhos.Where(e => e.maKho == update.MaKho || e.manhanvien == update.MaNV).FirstOrDefault();
            p.maKho = update.MaKho;
            p.chucVu = update.ChucVu;
            db.SubmitChanges();
        }
    }
}
