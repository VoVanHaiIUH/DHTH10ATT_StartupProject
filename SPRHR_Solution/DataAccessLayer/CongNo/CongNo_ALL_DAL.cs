using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.CongNo;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.CongNo
{
    public class CongNo_ALL_DAL
    {
        private SPRHR_SolutionDataContext db;
        public CongNo_ALL_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        /// <summary>
        /// Lấy danh sách nhà cung cấp có công nợ
        /// </summary>
        /// <returns>danh sách nhà cung cấp</returns>
        public List<eNhaCungCap> GetListNhaCungCapNo()
        {
            List<eNhaCungCap> l = new List<eNhaCungCap>();
            foreach (var cn in db.CongNoNCCs)
            {
                NhaCungCap ncc = cn.HoaDonNhaCungCap.NhaCungCap;
                eNhaCungCap encc = new eNhaCungCap();

                encc.MaNCC = ncc.MaNhaCungCap;
                encc.TenNCC = ncc.TenNhaCungCap;
                encc.DiaChi = ncc.DiaChi;
                encc.Phone = ncc.Phone;
                // entity thiếu field NgayThanhLap so với data base; -- cập nhập ngày 15/11/2016
                l.Add(encc);

            }
            return l;
        }
        /// <summary>
        /// Lấy danh sách khách hàng nợ 
        /// </summary>
        /// <returns>danh sách khách hàng</returns>
        public List<eKhachHang> GetListKhachHangNo()
        {
            List<eKhachHang> l = new List<eKhachHang>();
            foreach (var cn in db.CongNoKHs)
            {
                KhachHang kh = cn.HoaDonBanSi.KhachHang;
                eKhachHang ekh = new eKhachHang();

                ekh.MaKH = kh.MaKH;
                ekh.DiaChi = kh.DiaChiKH;
                ekh.SDTKH = kh.SDTKH;
                ekh.GioiTinh = kh.GioiTinh;
                ekh.TenKH = kh.TenKH;
                ekh.MaSoThue = kh.MaSoThue;
                ekh.TenCongTy = kh.TenCongTy;
                ekh.DiaChiCongTy = kh.DiaChiCongTy;
                ekh.SDTCongTy = kh.SDTCongTy;
                ekh.EmailCongTy = kh.EmailCongTy;
                ekh.SoTaiKhoanNH = kh.SoTaiKhoanNH;
                l.Add(ekh);

            }
            return l;
        }
        /// <summary>
        /// lấy danh sách nợ của 1 nhà cung cấp nào đó
        /// </summary>
        /// <param name="pMaNhaCungCap">mã của nhà cung cấp cần lấy</param>
        /// <returns>danh sách công nợ của nhà cung cấp đó</returns>
        public List<eCongNoNCC> GetListNoCuaNoCungCap(string pMaNhaCungCap)
        {
            List<eCongNoNCC> l = new List<eCongNoNCC>();
            foreach (var cn in db.CongNoNCCs)
            {
                if (cn.HoaDonNhaCungCap.MaNhaCungCap == pMaNhaCungCap)
                {
                    eCongNoNCC ecn = new eCongNoNCC();
                    ecn.MaHoaDonNCC = cn.MaHoaDonNCC;
                    ecn.SoTienNo = cn.SoTienNo;
                    ecn.GhiChu = cn.GhiChu;
                    ecn.NgayDaoHan = cn.NgayDaoHan;
                    l.Add(ecn);
                }
            }
            return l;
        }
        /// <summary>
        /// lấy danh sách nợ của 1 khách hàng nào đó
        /// </summary>
        /// <param name="pMaKhachHang">mã khách hàng</param>
        /// <returns>danh sách công nợ của khách hàng</returns>
        public List<eCongNoKhachHang> GetListNoCuaNoKhachHang(string pMaKhachHang)
        {
            List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
            foreach (var cn in db.CongNoKHs)
            {
                if (cn.HoaDonBanSi.MaKH == pMaKhachHang)
                {
                    eCongNoKhachHang ecn = new eCongNoKhachHang();
                    ecn.MaHoaDonBanSi = cn.MaHoaDonBanSi;
                    ecn.SoTienNo = cn.SoTienNo;
                    ecn.GhiChu = cn.GhiChu;
                    ecn.NgayDaoHan = cn.NgayDaoHan;
                    l.Add(ecn);
                }
            }
            return l;
        }
        /// <summary>
        /// Lấy danh sách chi tiét trả nợ của nhà cung cấp cho 1 khoản nợ nào đó
        /// </summary>
        /// <param name="pMaHoaDon">mã hóa đơn nợ</param>
        /// <returns>danh sách chi tiết phiếu trả nợ</returns>
        public List<eChiTietPhieuTraNoNCC> GetListChiTietTraNoNCC(string pMaHoaDon)
        {
            List<eChiTietPhieuTraNoNCC> l = new List<eChiTietPhieuTraNoNCC>();
            foreach (var ct in db.ChiTietPhieuTraNoNCCs.Where(e => e.MaHoaDonNCC == pMaHoaDon))
            {
                eChiTietPhieuTraNoNCC ect = new eChiTietPhieuTraNoNCC();

                ect.SoTien = ct.SoTien;
                ect.GhiChu = ct.GhiChu;
                ect.MaHoaDonNCC = ct.MaHoaDonNCC;
                ect.MaChiTietPhieuTraNoNCC = ct.MaChiTietPhieuTraNoNCC;
                ect.MaNhanVien = ct.MaNhanVien;
                ect.NgayTra = ct.NgayTra;
                l.Add(ect);
            }
            return l;
        }
        /// <summary>
        /// lấy danh sách chi tiết trả nợ của khách hàng cho 1 khoản nợ nào đó
        /// </summary>
        /// <param name="pMaHoaDon">mã hóa đơn nợ</param>
        /// <returns>danh sách chi tiết phiểu trả nợ</returns>
        public List<eChiTietPhieuTraNoKhachHang> GetListChiTietTraNoKH(string pMaHoaDon)
        {
            List<eChiTietPhieuTraNoKhachHang> l = new List<eChiTietPhieuTraNoKhachHang>();
            foreach (var ct in db.ChiTietPhieuTraNoKhachHangs.Where(e => e.MaHoaDonBanSi == pMaHoaDon))
            {
                eChiTietPhieuTraNoKhachHang ect = new eChiTietPhieuTraNoKhachHang();

                ect.SoTien = ct.SoTien;
                ect.GhiChu = ct.GhiChu;
                ect.MaHoaDonBanSi = ct.MaHoaDonBanSi;
                ect.MaChiTietPhieuTraNoKH = ct.MaChiTietPhieuTraNoKH;
                ect.MaNhanVien = ct.MaNhanVien;
                ect.NgayTra = ct.NgayTra;
                l.Add(ect);
            }
            return l;
        }
        /// <summary>
        /// Tạo mã cho chi tiết phiếu trả nợ
        /// </summary>
        /// <returns>Mã chi tiết phiếu trả nợ mới</returns>
        private string TaoMaChiTietPhieuTraNoNCC()
        {
            try
            {
                string maChiTietPhieuEnd = db.ChiTietPhieuTraNoNCCs.OrderBy(e => e.MaChiTietPhieuTraNoNCC).FirstOrDefault().MaChiTietPhieuTraNoNCC;
                int indexEnd = int.Parse(maChiTietPhieuEnd.Substring(8));
                indexEnd++;
                return "CTPTNNCC" + string.Format("{0:000", indexEnd);
            }
            catch (ArgumentNullException)
            {
                return "CTPTNNCC001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tạo mã cho chi tiết phiếu trả nợ
        /// </summary>
        /// <returns>Mã chi tiết phiếu trả nợ mới</returns>
        private string TaoMaChiTietPhieuTraNoKH()
        {
            try
            {
                string maChiTietPhieuEnd = db.ChiTietPhieuTraNoKhachHangs.OrderBy(e => e.MaChiTietPhieuTraNoKH).FirstOrDefault().MaChiTietPhieuTraNoKH;
                int indexEnd = int.Parse(maChiTietPhieuEnd.Substring(7));
                indexEnd++;
                return "CTPTNKH" + string.Format("{0:000", indexEnd);
            }
            catch (ArgumentNullException)
            {
                return "CTPTNKH001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        private void KiemTraTraNoNCC(string pMaHoaDon, decimal pSoTienTra)
        {
            // kiểm tra
            if (db.CongNoNCCs.Where(e => e.MaHoaDonNCC == pMaHoaDon).FirstOrDefault() == null)
                throw new Exception("Không có công nợ cho hóa đơn này");
            decimal soTienDaTra = db.ChiTietPhieuTraNoNCCs.Where(e => e.MaHoaDonNCC == pMaHoaDon).Sum(e => e.SoTien);
            decimal soTienNo = db.CongNoNCCs.Where(e => e.MaHoaDonNCC == pMaHoaDon).FirstOrDefault().SoTienNo;
            if (soTienDaTra == soTienNo)
                throw new Exception("Nợ đã trả hết rồi");
            if (soTienNo - soTienDaTra < pSoTienTra)
                throw new Exception("Trả dư rồi");
        }
        private void KiemTraTraNoKH(string pMaHoaDon, decimal pSoTienTra)
        {
            // kiểm tra
            if (db.CongNoKHs.Where(e => e.MaHoaDonBanSi == pMaHoaDon).FirstOrDefault() == null)
                throw new Exception("Không có công nợ cho hóa đơn này");
            decimal soTienDaTra = db.ChiTietPhieuTraNoKhachHangs.Where(e => e.MaHoaDonBanSi == pMaHoaDon).Sum(e => e.SoTien);
            decimal soTienNo = db.CongNoKHs.Where(e => e.MaHoaDonBanSi == pMaHoaDon).FirstOrDefault().SoTienNo;
            if (soTienDaTra == soTienNo)
                throw new Exception("Nợ đã trả hết rồi");
            if (soTienNo - soTienDaTra < pSoTienTra)
                throw new Exception("Thu dư rồi");
        }

        public eChiTietPhieuTraNoNCC TraNoNCC(string pMaHoaDonNCC, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            KiemTraTraNoNCC(pMaHoaDonNCC, pSoTien);
            ChiTietPhieuTraNoNCC ct = new ChiTietPhieuTraNoNCC();
            eChiTietPhieuTraNoNCC ect = new eChiTietPhieuTraNoNCC();
            ct.MaChiTietPhieuTraNoNCC = ect.MaChiTietPhieuTraNoNCC = TaoMaChiTietPhieuTraNoNCC();
            ct.SoTien = ect.SoTien = pSoTien;
            ct.MaNhanVien = ect.MaNhanVien = pMaNhanVien;
            ct.NgayTra = ect.NgayTra = DateTime.Now;
            ct.MaHoaDonNCC = ect.MaHoaDonNCC = pMaHoaDonNCC;
            ct.GhiChu = ect.GhiChu = pGhiChu;
            try
            {
                db.ChiTietPhieuTraNoNCCs.InsertOnSubmit(ct);
                db.SubmitChanges();
                return ect;
            }
            catch
            {
                return null;
            }
        }
        public eChiTietPhieuTraNoKhachHang ThuNoKH(string pMaHoaDonBanSi, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            KiemTraTraNoKH(pMaHoaDonBanSi, pSoTien);
            ChiTietPhieuTraNoKhachHang ct = new ChiTietPhieuTraNoKhachHang();
            eChiTietPhieuTraNoKhachHang ect = new eChiTietPhieuTraNoKhachHang();
            ct.MaChiTietPhieuTraNoKH = ect.MaChiTietPhieuTraNoKH = TaoMaChiTietPhieuTraNoKH();
            ct.SoTien = ect.SoTien = pSoTien;
            ct.MaNhanVien = ect.MaNhanVien = pMaNhanVien;
            ct.NgayTra = ect.NgayTra = DateTime.Now;
            ct.MaHoaDonBanSi = ect.MaHoaDonBanSi = pMaHoaDonBanSi;
            ct.GhiChu = ect.GhiChu = pGhiChu;
            try
            {
                db.ChiTietPhieuTraNoKhachHangs.InsertOnSubmit(ct);
                db.SubmitChanges();
                return ect;
            }
            catch
            {
                return null;
            }
        }
        public eCongNoNCC GhiNoNhaCungCap(string pMaHoaDonNCC, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            if (db.CongNoNCCs.Where(e => e.MaHoaDonNCC == pMaHoaDonNCC) != null)
                throw new Exception("Đã tồn tại công nợ cho hóa đơn này rồi");
            eCongNoNCC ecn = new eCongNoNCC();
            CongNoNCC cn = new CongNoNCC();
            ecn.NgayDaoHan = cn.NgayDaoHan = pNgayDaoHan;
            ecn.MaHoaDonNCC = cn.MaHoaDonNCC = pMaHoaDonNCC;
            ecn.SoTienNo = cn.SoTienNo = pSoTien;
            ecn.GhiChu = cn.GhiChu = pGhiChu;
            try
            {
                db.CongNoNCCs.InsertOnSubmit(cn);
                db.SubmitChanges();
                return ecn;
            }
            catch
            {
                return null;
            }
        }
        public eCongNoKhachHang GhiNoKhachHang(string pMaHoaDonBanSi, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            if (db.CongNoKHs.Where(e => e.MaHoaDonBanSi == pMaHoaDonBanSi) != null)
                throw new Exception("Đã tồn tại công nợ cho hóa đơn này rồi");
            eCongNoKhachHang ecn = new eCongNoKhachHang();
            CongNoKH cn = new CongNoKH();
            ecn.NgayDaoHan = cn.NgayDaoHan = pNgayDaoHan;
            ecn.MaHoaDonBanSi = cn.MaHoaDonBanSi = pMaHoaDonBanSi;
            ecn.SoTienNo = cn.SoTienNo = pSoTien;
            ecn.GhiChu = cn.GhiChu = pGhiChu;
            try
            {
                db.CongNoKHs.InsertOnSubmit(cn);
                db.SubmitChanges();
                return ecn;
            }
            catch
            {
                return null;
            }
        }
        

    }
}
