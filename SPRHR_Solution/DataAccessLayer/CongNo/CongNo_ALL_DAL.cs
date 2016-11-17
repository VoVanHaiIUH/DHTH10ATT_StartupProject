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
        //private string TaoMaCongNoKhachHang()
        //{
        //    // công nợ khách hàng có dạng CNKH_dd/MM/yy_xxxx
        //    string maCongNoKHEnd = db.CongNoKHs.OrderByDescending(e => e.MaSoCNKH).FirstOrDefault().MaSoCNKH;
        //    if (maCongNoKHEnd == null)
        //    {

        //        // trường hợp chưa có công nợ khách hàng nào
        //        string ngay = DateTime.Now.ToString("dd/MM/yy");
        //        return "CNKH_" + ngay + "_0001";
        //    }
        //    else
        //    {
        //        //nếu có công nợ rồi
        //        // kiểm tra phải ngày hôm nay không
        //        string strDateEnd = maCongNoKHEnd.Substring(5, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
        //        DateTime dateEnd = DateTime.Parse(strDateEnd);
        //        if ((DateTime.Now - dateEnd).TotalDays == 0)
        //        {
        //            // dateEnd là ngày hôm nay
        //            string strSoThuTuEnd = maCongNoKHEnd.Substring(16);
        //            int soThuTuEnd = int.Parse(strSoThuTuEnd);
        //            int soThuTuMoi = soThuTuEnd + 1;
        //            string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "CNKH_" + ngay + "_" + strSoThuTuMoi;
        //        }
        //        else
        //        {
        //            // dateEnd trước ngày hôm nay
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "CNKH_" + ngay + "_0001";
        //        }
        //    }
        //}
        //private string TaoMaCongNoNCC()
        //{
        //    // công nợ nhà cung cấp có dạng CNNCC_dd/MM/yy_xxxx
        //    string maCongNoKHEnd = db.CongNoKHs.OrderByDescending(e => e.MaSoCNKH).FirstOrDefault().MaSoCNKH;
        //    if (maCongNoKHEnd == null)
        //    {
        //        // trường hợp chưa có công nợ khách hàng nào
        //        string ngay = DateTime.Now.ToString("dd/MM/yy");
        //        return "CNNCC_" + ngay + "_0001";
        //    }
        //    else
        //    {
        //        //nếu có công nợ rồi
        //        // kiểm tra phải ngày hôm nay không
        //        string strDateEnd = maCongNoKHEnd.Substring(6, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
        //        DateTime dateEnd = DateTime.Parse(strDateEnd);
        //        if ((DateTime.Now - dateEnd).TotalDays == 0)
        //        {
        //            // dateEnd là ngày hôm nay
        //            string strSoThuTuEnd = maCongNoKHEnd.Substring(17);
        //            int soThuTuEnd = int.Parse(strSoThuTuEnd);
        //            int soThuTuMoi = soThuTuEnd + 1;
        //            string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "CNNCC_" + ngay + "_" + strSoThuTuMoi;
        //        }
        //        else
        //        {
        //            // dateEnd trước ngày hôm nay
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "CNNCC_" + ngay + "_0001";
        //        }
        //    }
        //}
        //private string TaoMaPhieuTraNoKhachHang()
        //{
        //    // số phiếu trả nợ khách hàng có dạng PTNKH_dd/MM/yy_xxxx
        //    string maPhieuTraNoKHEnd = db.PhieuTraNoKHs.OrderByDescending(e => e.SoPhieuTraNo).FirstOrDefault().SoPhieuTraNo;
        //    if (maPhieuTraNoKHEnd == null)
        //    {
        //        // trường hợp chưa có công nợ khách hàng nào
        //        string ngay = DateTime.Now.ToString("dd/MM/yy");
        //        return "PTNKH_" + ngay + "_0001";
        //    }
        //    else
        //    {
        //        //nếu có khách hàng trả nợ rồi
        //        // kiểm tra phải ngày hôm nay không
        //        string strDateEnd = maPhieuTraNoKHEnd.Substring(6, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
        //        DateTime dateEnd = DateTime.Parse(strDateEnd);
        //        if ((DateTime.Now - dateEnd).TotalDays == 0)
        //        {
        //            // dateEnd là ngày hôm nay
        //            string strSoThuTuEnd = maPhieuTraNoKHEnd.Substring(17);
        //            int soThuTuEnd = int.Parse(strSoThuTuEnd);
        //            int soThuTuMoi = soThuTuEnd + 1;
        //            string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "PTNKH_" + ngay + "_" + strSoThuTuMoi;
        //        }
        //        else
        //        {
        //            // dateEnd trước ngày hôm nay
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "PTNKH_" + ngay + "_0001";
        //        }
        //    }
        //}
        //private string TaoMaPhieuTraNoNCC()
        //{
        //    // số phiếu trả nợ khách hàng có dạng PTNKH_dd/MM/yy_xxxx
        //    string maPhieuTraNoNCCEnd = db.PhieuTraNoNCCs.OrderByDescending(e => e.SoPhieuTraNo).FirstOrDefault().SoPhieuTraNo;
        //    if (maPhieuTraNoNCCEnd == null)
        //    {
        //        // trường hợp chưa có công nợ khách hàng nào
        //        string ngay = DateTime.Now.ToString("dd/MM/yy");
        //        return "PTNNCC_" + ngay + "_0001";
        //    }
        //    else
        //    {
        //        //nếu có khách hàng trả nợ rồi
        //        // kiểm tra phải ngày hôm nay không
        //        string strDateEnd = maPhieuTraNoNCCEnd.Substring(7, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
        //        DateTime dateEnd = DateTime.Parse(strDateEnd);
        //        if ((DateTime.Now - dateEnd).TotalDays == 0)
        //        {
        //            // dateEnd là ngày hôm nay
        //            string strSoThuTuEnd = maPhieuTraNoNCCEnd.Substring(17);
        //            int soThuTuEnd = int.Parse(strSoThuTuEnd);
        //            int soThuTuMoi = soThuTuEnd + 1;
        //            string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "PTNNCC_" + ngay + "_" + strSoThuTuMoi;
        //        }
        //        else
        //        {
        //            // dateEnd trước ngày hôm nay
        //            string ngay = DateTime.Now.ToString("dd/MM/yy");
        //            return "PTNNCC_" + ngay + "_0001";
        //        }
        //    }
        //}
        //public List<eKhachHang> GetListKhachHangNo()
        //{
        //    List<eKhachHang> l = new List<eKhachHang>();
        //    foreach (var cn in db.CongNoKHs)
        //    {
        //        string maKHNo = cn.HoaDonBanSi.MaKH;
        //        KhachHang kh = db.KhachHangs.Where(e => e.MaKH == maKHNo).FirstOrDefault();
        //        eKhachHang ekh = new eKhachHang();

        //        ekh.MaKH = kh.MaKH;
        //        ekh.DiaChi = kh.DiaChiKH;
        //        ekh.SDTKH = kh.SDTKH;
        //        ekh.GioiTinh = kh.GioiTinh;
        //        ekh.TenKH = kh.TenKH;
        //        ekh.MaSoThue = kh.MaSoThue;
        //        ekh.TenCongTy = kh.TenCongTy;
        //        ekh.DiaChiCongTy = kh.DiaChiCongTy;
        //        ekh.SDTCongTy = kh.SDTCongTy;
        //        ekh.EmailCongTy = kh.EmailCongTy;
        //        ekh.SoTaiKhoanNH = kh.SoTaiKhoanNH;

        //        l.Add(ekh);
        //    }
        //    return l;
        //}
        //public List<eNhaCungCap> GetListNCCNo()
        //{
        //    List<eNhaCungCap> l = new List<eNhaCungCap>();
        //    foreach (var cnncc in db.CongNoNCCs)
        //    {
        //        string maNCC = cnncc.HoaDonNhaCungCap.MaNhaCungCap;

        //        NhaCungCap ncc = db.NhaCungCaps.Where(e => e.MaNhaCungCap == maNCC).FirstOrDefault();
        //        eNhaCungCap encc = new eNhaCungCap();

        //        encc.MaNCC = ncc.MaNhaCungCap;
        //        encc.TenNCC = ncc.TenNhaCungCap;
        //        encc.DiaChi = ncc.DiaChi;
        //        encc.Phone = ncc.Phone;
        //        // 
        //        l.Add(encc);
        //    }
        //    return l;
        //}
        //public List<eCongNoNCC> GetCongNoNCC(string pMaNCC)
        //{
        //    //NhaCungCap ncc = db.NhaCungCaps.Where(e => e.MaNhaCungCap == pMaNCC).FirstOrDefault();
        //    //foreach (var hdncc in ncc.HoaDonNhaCungCaps)
        //    //{
        //    //    hdncc.CongNoNCCs;
        //    //    string a;
        //    //    a.Length
        //    //}
        //    return null;

        //}
        //public eCongNoKhachHang ThemMoiCongNoKhachHang(string pMaHoaDonBanSi, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        //{
        //    CongNoKH congNoKhachHang = new CongNoKH();
        //    congNoKhachHang.MaSoCNKH = TaoMaCongNoKhachHang();
        //    congNoKhachHang.MaHoaDonBanSi = pMaHoaDonBanSi;
        //    congNoKhachHang.SoTienNo = pSoTienNo;
        //    congNoKhachHang.NgayDaoHan = pNgayDaoHan;
        //    congNoKhachHang.GhiChu = pGhiChu;
        //    db.CongNoKHs.InsertOnSubmit(congNoKhachHang);
        //    db.SubmitChanges();
        //    return new eCongNoKhachHang(congNoKhachHang.MaSoCNKH, congNoKhachHang.MaHoaDonBanSi, congNoKhachHang.SoTienNo, congNoKhachHang.NgayDaoHan, congNoKhachHang.GhiChu);
        //}
        //public eCongNoNCC ThemMoiCongNoNCC(string pMaHoaDonNCC, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        //{
        //    CongNoNCC congNoNCC = new CongNoNCC();
        //    congNoNCC.MaSoCongNoNCC = TaoMaCongNoNCC();
        //    congNoNCC.MaHoaDonNCC = pMaHoaDonNCC;
        //    congNoNCC.SoTienNo = pSoTienNo;
        //    congNoNCC.NgayDaoHan = pNgayDaoHan;
        //    congNoNCC.GhiChu = pGhiChu;
        //    db.CongNoNCCs.InsertOnSubmit(congNoNCC);
        //    db.SubmitChanges();
        //    return new eCongNoNCC(congNoNCC.MaSoCongNoNCC, congNoNCC.MaHoaDonNCC, congNoNCC.SoTienNo, congNoNCC.NgayDaoHan, congNoNCC.GhiChu);
        //}
        //public List<string> GetListMaHoaDonBanSiNo()
        //{
        //    List<string> dsMaHoaDonBanSi = new List<string>();
        //    foreach (CongNoKH cnKH in db.CongNoKHs)
        //    {
        //        decimal congNo = cnKH.SoTienNo;
        //        foreach (ChiTietPhieuTraNoKhachHang item in cnKH.ChiTietPhieuTraNoKhachHangs)
        //        {
        //            congNo -= item.SoTien;
        //        }
        //        if (congNo > 0)
        //        {
        //            dsMaHoaDonBanSi.Add(cnKH.MaHoaDonBanSi);
        //        }
        //    }
        //    return dsMaHoaDonBanSi;
        //}
        //public List<string> GetListMaHoaDonNCC()
        //{
        //    List<string> dsMaHoaDonNCC = new List<string>();
        //    foreach (CongNoNCC cnNCC in db.CongNoNCCs)
        //    {
        //        decimal congNo = cnNCC.SoTienNo;
        //        foreach (ChiTietPhieuTraNoNCC item in cnNCC.ChiTietPhieuTraNoNCCs)
        //        {
        //            congNo -= item.SoTien;
        //        }
        //        if (congNo > 0)
        //        {
        //            dsMaHoaDonNCC.Add(cnNCC.MaHoaDonNCC);
        //        }
        //    }
        //    return dsMaHoaDonNCC;
        //}
        //public ePhieuTraNoKhachHang KhachHangTraNo(ePhieuTraNoKhachHang pPhieuTraNoKhachHang)
        //{
        //    try
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {
        //            PhieuTraNoKH phieuTraNoKH = new PhieuTraNoKH();
        //            phieuTraNoKH.SoPhieuTraNo = pPhieuTraNoKhachHang.SoPhieuTraNo;
        //            phieuTraNoKH.MaKH = pPhieuTraNoKhachHang.MaKH;
        //            phieuTraNoKH.NgayTra = pPhieuTraNoKhachHang.NgayTra;
        //            phieuTraNoKH.MaNhanVien = pPhieuTraNoKhachHang.MaNhanVien;
        //            phieuTraNoKH.NoiDung = pPhieuTraNoKhachHang.NoiDung;
        //            db.PhieuTraNoKHs.InsertOnSubmit(phieuTraNoKH);

        //            db.SubmitChanges();
        //            foreach (eChiTietPhieuTraNoKhachHang eChiTiet in pPhieuTraNoKhachHang.DSChiTietPhieuTraNo)
        //            {
        //                ChiTietPhieuTraNoKhachHang chiTietPhieuTraNoKH = new ChiTietPhieuTraNoKhachHang();
        //                chiTietPhieuTraNoKH.SoPhieuTraNo = eChiTiet.SoPhieuTraNo;
        //                chiTietPhieuTraNoKH.MaSoCNKH = eChiTiet.MaSoCNKH;
        //                chiTietPhieuTraNoKH.SoTien = eChiTiet.SoTien;
        //                chiTietPhieuTraNoKH.GhiChu = eChiTiet.GhiChu;
        //                db.ChiTietPhieuTraNoKhachHangs.InsertOnSubmit(chiTietPhieuTraNoKH);
        //                db.SubmitChanges();
        //            }
        //            ts.Complete();
        //            return pPhieuTraNoKhachHang;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public ePhieuTraNoNCC TraNoNCC(ePhieuTraNoNCC pPhieuTraNoNCC)
        //{
        //    try
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {
        //            PhieuTraNoNCC phieuTraNoNCC = new PhieuTraNoNCC();
        //            phieuTraNoNCC.SoPhieuTraNo = pPhieuTraNoNCC.SoPhieuTraNo;
        //            phieuTraNoNCC.MaNhaCungCap = pPhieuTraNoNCC.MaNhaCungCap;
        //            phieuTraNoNCC.NgayTra = pPhieuTraNoNCC.NgayTra;
        //            phieuTraNoNCC.MaNhanVien = pPhieuTraNoNCC.MaNhanVien;
        //            phieuTraNoNCC.NoiDung = pPhieuTraNoNCC.NoiDung;
        //            db.PhieuTraNoNCCs.InsertOnSubmit(phieuTraNoNCC);

        //            db.SubmitChanges();
        //            foreach (eChiTietPhieuTraNoNCC eChiTiet in pPhieuTraNoNCC.DSChiTietPhieuTraNo)
        //            {
        //                ChiTietPhieuTraNoNCC chiTietPhieuTraNoNCC = new ChiTietPhieuTraNoNCC();
        //                chiTietPhieuTraNoNCC.SoPhieuTraNo = eChiTiet.SoPhieuTraNo;
        //                chiTietPhieuTraNoNCC.MaSoCongNoNCC = eChiTiet.MaSoCongNoNCC;
        //                chiTietPhieuTraNoNCC.SoTien = eChiTiet.SoTien;
        //                chiTietPhieuTraNoNCC.GhiChu = eChiTiet.GhiChu;
        //                db.ChiTietPhieuTraNoNCCs.InsertOnSubmit(chiTietPhieuTraNoNCC);
        //                db.SubmitChanges();
        //            }
        //            ts.Complete();
        //            return pPhieuTraNoNCC;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public List<eChiTietPhieuTraNoKhachHang> GetDSNoKhachHangDaTra()
        //{
        //    List<eChiTietPhieuTraNoKhachHang> l = new List<eChiTietPhieuTraNoKhachHang>();
        //    foreach (ChiTietPhieuTraNoKhachHang chiTietPhieuTraNoKhachHang in db.ChiTietPhieuTraNoKhachHangs)
        //    {
        //        eChiTietPhieuTraNoKhachHang eChiTiet = new eChiTietPhieuTraNoKhachHang();
        //        eChiTiet.SoPhieuTraNo = chiTietPhieuTraNoKhachHang.SoPhieuTraNo;
        //        eChiTiet.MaSoCNKH = chiTietPhieuTraNoKhachHang.MaSoCNKH;
        //        eChiTiet.SoTien = chiTietPhieuTraNoKhachHang.SoTien;
        //        eChiTiet.GhiChu = chiTietPhieuTraNoKhachHang.GhiChu;
        //        l.Add(eChiTiet);
        //    }
        //    return l;
        //}
        //public List<eChiTietPhieuTraNoNCC> GetDSNoNCCDaTra()
        //{
        //    List<eChiTietPhieuTraNoNCC> l = new List<eChiTietPhieuTraNoNCC>();
        //    foreach (ChiTietPhieuTraNoNCC chiTietPhieuTranoNCC in db.ChiTietPhieuTraNoNCCs)
        //    {
        //        eChiTietPhieuTraNoNCC eChiTiet = new eChiTietPhieuTraNoNCC();
        //        eChiTiet.SoPhieuTraNo = chiTietPhieuTranoNCC.SoPhieuTraNo;
        //        eChiTiet.MaSoCongNoNCC = chiTietPhieuTranoNCC.MaSoCongNoNCC;
        //        eChiTiet.SoTien = chiTietPhieuTranoNCC.SoTien;
        //        eChiTiet.GhiChu = chiTietPhieuTranoNCC.GhiChu;
        //        l.Add(eChiTiet);
        //    }
        //    return l;
        //}
        //public List<eCongNoKhachHang> GetListCongNoKH(string maKH)
        //{
        //    List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
        //    foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.HoaDonBanSi.MaKH == maKH))
        //    {
        //        l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoKhachHang> GetListCongNoKH()
        //{
        //    List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
        //    foreach (CongNoKH congNo in db.CongNoKHs)
        //    {
        //        l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoNCC> GetListCongNoNCC(string maNCC)
        //{
        //    List<eCongNoNCC> l = new List<eCongNoNCC>();
        //    foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.HoaDonNhaCungCap.MaNhaCungCap == maNCC))
        //    {
        //        l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoNCC> GetListCongNoNCC()
        //{
        //    List<eCongNoNCC> l = new List<eCongNoNCC>();
        //    foreach (CongNoNCC congNo in db.CongNoNCCs)
        //    {
        //        l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoKhachHang> GetListNoKHQuaHan()
        //{
        //    List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
        //    foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 1))
        //    {
        //        l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoNCC> GetListNoNCCQuaHan()
        //{
        //    List<eCongNoNCC> l = new List<eCongNoNCC>();
        //    foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 1))
        //    {
        //        l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoKhachHang> GetListNoKHToiHan()
        //{
        //    List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
        //    foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 0))
        //    {
        //        l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}
        //public List<eCongNoNCC> GetListNoNCCToiHan()
        //{
        //    List<eCongNoNCC> l = new List<eCongNoNCC>();
        //    foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 0))
        //    {
        //        l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
        //    }
        //    return l;
        //}

    }
}
