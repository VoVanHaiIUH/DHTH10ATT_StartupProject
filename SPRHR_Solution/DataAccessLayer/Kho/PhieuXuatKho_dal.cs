using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
namespace DataAccessLayer.Kho
{
    public class PhieuXuatKho_dal
    {
        SPRHR_SolutionDataContext db;
        public PhieuXuatKho_dal()
        {
            db = new SPRHR_SolutionDataContext();
        }
        public List<ePhieuDeNghiXuatKho> GetPDNXK()
        {
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK pdn in db.PhieuDNXKs.Where(e => e.tinhtrang != 1))
            {
                ePhieuDeNghiXuatKho t = new ePhieuDeNghiXuatKho();
                t.SoPhieuDeNghiXuatKho = pdn.MaPhieuDNXK;
                t.NgayLap = pdn.NgayLap;
                t.MaKho = pdn.MaKho;

                ls.Add(t);
            }
            return ls;
        }

        public List<ePhieuDeNghiXuatKho> GetPDNXKbyMa(string ma)
        {
            List<ePhieuDeNghiXuatKho> ls = new List<ePhieuDeNghiXuatKho>();
            foreach (PhieuDNXK pdn in db.PhieuDNXKs.Where(e => e.MaPhieuDNXK == ma ))
            {
                ePhieuDeNghiXuatKho t = new ePhieuDeNghiXuatKho();
                t.SoPhieuDeNghiXuatKho = pdn.MaPhieuDNXK;
                t.NgayLap = pdn.NgayLap;
                t.MaKho = pdn.MaKho;

                ls.Add(t);
            }
            return ls;
        }

        private int UpdateSoLuong(string maphieu)
        {
            foreach (PhieuDNXK pdn in db.PhieuDNXKs.Where(p => p.MaPhieuDNXK == maphieu))
            {
                foreach (ChiTietPhieuDNXK ctdn in db.ChiTietPhieuDNXKs.Where(e => e.MaPhieuDNXK == maphieu))
                {
                    ChiTietKho ctkho = db.ChiTietKhos.Where(k => k.maSP == ctdn.MaSP && k.maKho == pdn.MaKho).FirstOrDefault();
                    if (ctkho == null)
                    {
                        throw new Exception("Sản phẩm không có trong kho");
                    }
                    else
                    {
                        if (ctdn.SoLuong > ctkho.soLuong)
                            throw new Exception("Số Lượng trong kho không đủ");
                        else
                        {
                            ctkho.soLuong -= ctdn.SoLuong;
                            db.SubmitChanges();
                        }
                    }
                }
            }
            return 1;
        }
        private void tinhtrang(string ma)
        {
            PhieuDNXK p = db.PhieuDNXKs.Where(e => e.MaPhieuDNXK == ma).FirstOrDefault();
            if (p != null)
            {
                p.tinhtrang = 1;
                db.SubmitChanges();
            }
        }
        public int taophieuxuatkho(ePhieuXuatKho e)
        {
            if (ktranv(e.MaNV, e.MaKho))
                throw new Exception("Bạn không phải nhân viên kho này");
            PhieuXuatKho px = new PhieuXuatKho();
            px.soPXK = e.SoPXK;
            px.manhanvien = e.MaNV;
            px.ngaylap = e.NgayLap;
            px.makho = e.MaKho;
            UpdateSoLuong(e.SoPXK);
            tinhtrang(e.SoPXK);
            db.PhieuXuatKhos.InsertOnSubmit(px);
            db.SubmitChanges();
            return 1;
        }

        private bool ktranv(string maNV, string maKho)
        {
            QuanLyKho ql = db.QuanLyKhos.Where(q => q.manhanvien == maNV && q.maKho == maKho && q.thoiGianKetThuc == null).FirstOrDefault();
            if (ql != null)
                return false;
            return true;
        }

        public void LoadChiTiet(string maphieu, string makho, DataGridView dgv)
        {
            var query = from px in db.PhieuDNXKs
                        where px.MaPhieuDNXK == maphieu
                        from ct in db.ChiTietPhieuDNXKs
                        where ct.MaPhieuDNXK == px.MaPhieuDNXK
                        from sp in db.SanPhams
                        where sp.MaSP == ct.MaSP
                        select new
                        {
                            px.MaPhieuDNXK,
                            ct.MaSP,
                            sp.TenSp,
                            ct.SoLuong,
                            px.MaKH,
                            px.MaCuaHang,px.MaHoaDonBanSi
                        };
            dgv.DataSource = query.ToList();
        }
    }
}
