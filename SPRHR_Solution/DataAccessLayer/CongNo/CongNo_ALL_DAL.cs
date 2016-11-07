using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.CongNo;

namespace DataAccessLayer.CongNo
{
    public class CongNo_ALL_DAL
    {
        private SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        private string TaoMaCongNoKhachHang()
        {
            // công nợ khách hàng có dạng CNKH_dd/MM/yy_xxxx
            string maCongNoKHEnd = db.CongNoKHs.OrderByDescending(e => e.MaSoCNKH).FirstOrDefault().MaSoCNKH;
            if (maCongNoKHEnd == null)
            {
                // trường hợp chưa có công nợ khách hàng nào
                string ngay = DateTime.Now.ToString("dd/MM/yy");
                return "CNKH_" + ngay + "_0001";
            }
            else
            {
                //nếu có công nợ rồi
                // kiểm tra phải ngày hôm nay không
                string strDateEnd = maCongNoKHEnd.Substring(5, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
                DateTime dateEnd = DateTime.Parse(strDateEnd);
                if ((DateTime.Now - dateEnd).TotalDays == 0)
                {
                    // dateEnd là ngày hôm nay
                    string strSoThuTuEnd = maCongNoKHEnd.Substring(16);
                    int soThuTuEnd = int.Parse(strSoThuTuEnd);
                    int soThuTuMoi = soThuTuEnd + 1;
                    string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "CNKH_" + ngay + "_" + strSoThuTuMoi;
                }
                else
                {
                    // dateEnd trước ngày hôm nay
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "CNKH_" + ngay + "_0001";
                }
            }
        }
        private string TaoMaCongNoNCC()
        {
            // công nợ nhà cung cấp có dạng CNNCC_dd/MM/yy_xxxx
            string maCongNoKHEnd = db.CongNoKHs.OrderByDescending(e => e.MaSoCNKH).FirstOrDefault().MaSoCNKH;
            if (maCongNoKHEnd == null)
            {
                // trường hợp chưa có công nợ khách hàng nào
                string ngay = DateTime.Now.ToString("dd/MM/yy");
                return "CNNCC_" + ngay + "_0001";
            }
            else
            {
                //nếu có công nợ rồi
                // kiểm tra phải ngày hôm nay không
                string strDateEnd = maCongNoKHEnd.Substring(6, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
                DateTime dateEnd = DateTime.Parse(strDateEnd);
                if ((DateTime.Now - dateEnd).TotalDays == 0)
                {
                    // dateEnd là ngày hôm nay
                    string strSoThuTuEnd = maCongNoKHEnd.Substring(17);
                    int soThuTuEnd = int.Parse(strSoThuTuEnd);
                    int soThuTuMoi = soThuTuEnd + 1;
                    string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "CNNCC_" + ngay + "_" + strSoThuTuMoi;
                }
                else
                {
                    // dateEnd trước ngày hôm nay
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "CNNCC_" + ngay + "_0001";
                }
            }
        }
        private string TaoMaPhieuTraNoKhachHang()
        {
            // số phiếu trả nợ khách hàng có dạng PTNKH_dd/MM/yy_xxxx
            string maPhieuTraNoKHEnd = db.PhieuTraNoKHs.OrderByDescending(e => e.SoPhieuTraNo).FirstOrDefault().SoPhieuTraNo;
            if (maPhieuTraNoKHEnd == null)
            {
                // trường hợp chưa có công nợ khách hàng nào
                string ngay = DateTime.Now.ToString("dd/MM/yy");
                return "PTNKH_" + ngay + "_0001";
            }
            else
            {
                //nếu có khách hàng trả nợ rồi
                // kiểm tra phải ngày hôm nay không
                string strDateEnd = maPhieuTraNoKHEnd.Substring(6, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
                DateTime dateEnd = DateTime.Parse(strDateEnd);
                if ((DateTime.Now - dateEnd).TotalDays == 0)
                {
                    // dateEnd là ngày hôm nay
                    string strSoThuTuEnd = maPhieuTraNoKHEnd.Substring(17);
                    int soThuTuEnd = int.Parse(strSoThuTuEnd);
                    int soThuTuMoi = soThuTuEnd + 1;
                    string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "PTNKH_" + ngay + "_" + strSoThuTuMoi;
                }
                else
                {
                    // dateEnd trước ngày hôm nay
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "PTNKH_" + ngay + "_0001";
                }
            }
        }
        private string TaoMaPhieuTraNoNCC()
        {
            // số phiếu trả nợ khách hàng có dạng PTNKH_dd/MM/yy_xxxx
            string maPhieuTraNoNCCEnd = db.PhieuTraNoNCCs.OrderByDescending(e => e.SoPhieuTraNo).FirstOrDefault().SoPhieuTraNo;
            if (maPhieuTraNoNCCEnd == null)
            {
                // trường hợp chưa có công nợ khách hàng nào
                string ngay = DateTime.Now.ToString("dd/MM/yy");
                return "PTNNCC_" + ngay + "_0001";
            }
            else
            {
                //nếu có khách hàng trả nợ rồi
                // kiểm tra phải ngày hôm nay không
                string strDateEnd = maPhieuTraNoNCCEnd.Substring(7, 10); // lấy ra ngày tháng năm có công nợ cuối cùng trong db
                DateTime dateEnd = DateTime.Parse(strDateEnd);
                if ((DateTime.Now - dateEnd).TotalDays == 0)
                {
                    // dateEnd là ngày hôm nay
                    string strSoThuTuEnd = maPhieuTraNoNCCEnd.Substring(17);
                    int soThuTuEnd = int.Parse(strSoThuTuEnd);
                    int soThuTuMoi = soThuTuEnd + 1;
                    string strSoThuTuMoi = string.Format("{0:0000}", soThuTuMoi);
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "PTNNCC_" + ngay + "_" + strSoThuTuMoi;
                }
                else
                {
                    // dateEnd trước ngày hôm nay
                    string ngay = DateTime.Now.ToString("dd/MM/yy");
                    return "PTNNCC_" + ngay + "_0001";
                }
            }
        }
        public eCongNoKhachHang ThemMoiCongNoKhachHang(string pMaHoaDonBanSi, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        {
            CongNoKH congNoKhachHang = new CongNoKH();
            congNoKhachHang.MaSoCNKH = TaoMaCongNoKhachHang();
            congNoKhachHang.MaHoaDonBanSi = pMaHoaDonBanSi;
            congNoKhachHang.SoTienNo = pSoTienNo;
            congNoKhachHang.NgayDaoHan = pNgayDaoHan;
            congNoKhachHang.GhiChu = pGhiChu;
            db.CongNoKHs.InsertOnSubmit(congNoKhachHang);
            db.SubmitChanges();
            return new eCongNoKhachHang(congNoKhachHang.MaSoCNKH, congNoKhachHang.MaHoaDonBanSi, congNoKhachHang.SoTienNo, congNoKhachHang.NgayDaoHan, congNoKhachHang.GhiChu);
        }
        public eCongNoNCC ThemMoiCongNoNCC(string pMaHoaDonNCC, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        {
            CongNoNCC congNoNCC = new CongNoNCC();
            congNoNCC.MaSoCongNoNCC = TaoMaCongNoNCC();
            congNoNCC.MaHoaDonNCC = pMaHoaDonNCC;
            congNoNCC.SoTienNo = pSoTienNo;
            congNoNCC.NgayDaoHan = pNgayDaoHan;
            congNoNCC.GhiChu = pGhiChu;
            db.CongNoNCCs.InsertOnSubmit(congNoNCC);
            db.SubmitChanges();
            return new eCongNoNCC(congNoNCC.MaSoCongNoNCC, congNoNCC.MaHoaDonNCC, congNoNCC.SoTienNo, congNoNCC.NgayDaoHan, congNoNCC.GhiChu);
        }
        public List<string> GetListMaHoaDonBanSiNo()
        {
            List<string> dsMaHoaDonBanSi = new List<string>();
            foreach (CongNoKH cnKH in db.CongNoKHs)
            {
                decimal congNo = cnKH.SoTienNo;
                foreach (ChiTietPhieuTraNoKhachHang item in cnKH.ChiTietPhieuTraNoKhachHangs)
                {
                    congNo -= item.SoTien;
                }
                if (congNo > 0)
                {
                    dsMaHoaDonBanSi.Add(cnKH.MaHoaDonBanSi);
                }
            }
            return dsMaHoaDonBanSi;
        }
        public List<string> GetListMaHoaDonNCC()
        {
            List<string> dsMaHoaDonNCC = new List<string>();
            foreach (CongNoNCC cnNCC in db.CongNoNCCs)
            {
                decimal congNo = cnNCC.SoTienNo;
                foreach (ChiTietPhieuTraNoNCC item in cnNCC.ChiTietPhieuTraNoNCCs)
                {
                    congNo -= item.SoTien;
                }
                if (congNo > 0)
                {
                    dsMaHoaDonNCC.Add(cnNCC.MaHoaDonNCC);
                }
            }
            return dsMaHoaDonNCC;
        }
        public ePhieuTraNoKhachHang KhachHangTraNo(ePhieuTraNoKhachHang pPhieuTraNoKhachHang)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    PhieuTraNoKH phieuTraNoKH = new PhieuTraNoKH();
                    phieuTraNoKH.SoPhieuTraNo = pPhieuTraNoKhachHang.SoPhieuTraNo;
                    phieuTraNoKH.MaKH = pPhieuTraNoKhachHang.MaKH;
                    phieuTraNoKH.NgayTra = pPhieuTraNoKhachHang.NgayTra;
                    phieuTraNoKH.maNhanVien = pPhieuTraNoKhachHang.MaNhanVien;
                    phieuTraNoKH.NoiDung = pPhieuTraNoKhachHang.NoiDung;
                    db.PhieuTraNoKHs.InsertOnSubmit(phieuTraNoKH);

                    db.SubmitChanges();
                    foreach (eChiTietPhieuTraNoKhachHang eChiTiet in pPhieuTraNoKhachHang.DSChiTietPhieuTraNo)
                    {
                        ChiTietPhieuTraNoKhachHang chiTietPhieuTraNoKH = new ChiTietPhieuTraNoKhachHang();
                        chiTietPhieuTraNoKH.SoPhieuTraNo = eChiTiet.SoPhieuTraNo;
                        chiTietPhieuTraNoKH.MaSoCNKH = eChiTiet.MaSoCNKH;
                        chiTietPhieuTraNoKH.SoTien = eChiTiet.SoTien;
                        chiTietPhieuTraNoKH.GhiChu = eChiTiet.GhiChu;
                        db.ChiTietPhieuTraNoKhachHangs.InsertOnSubmit(chiTietPhieuTraNoKH);
                        db.SubmitChanges();
                    }
                    ts.Complete();
                    return pPhieuTraNoKhachHang;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ePhieuTraNoNCC TraNoNCC(ePhieuTraNoNCC pPhieuTraNoNCC)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    PhieuTraNoNCC phieuTraNoNCC = new PhieuTraNoNCC();
                    phieuTraNoNCC.SoPhieuTraNo = pPhieuTraNoNCC.SoPhieuTraNo;
                    phieuTraNoNCC.MaNhaCungCap = pPhieuTraNoNCC.MaNhaCungCap;
                    phieuTraNoNCC.NgayTra = pPhieuTraNoNCC.NgayTra;
                    phieuTraNoNCC.maNhanVien = pPhieuTraNoNCC.MaNhanVien;
                    phieuTraNoNCC.NoiDung = pPhieuTraNoNCC.NoiDung;
                    db.PhieuTraNoNCCs.InsertOnSubmit(phieuTraNoNCC);

                    db.SubmitChanges();
                    foreach (eChiTietPhieuTraNoNCC eChiTiet in pPhieuTraNoNCC.DSChiTietPhieuTraNo)
                    {
                        ChiTietPhieuTraNoNCC chiTietPhieuTraNoNCC = new ChiTietPhieuTraNoNCC();
                        chiTietPhieuTraNoNCC.SoPhieuTraNo = eChiTiet.SoPhieuTraNo;
                        chiTietPhieuTraNoNCC.MaSoCongNoNCC = eChiTiet.MaSoCongNoNCC;
                        chiTietPhieuTraNoNCC.SoTien = eChiTiet.SoTien;
                        chiTietPhieuTraNoNCC.GhiChu = eChiTiet.GhiChu;
                        db.ChiTietPhieuTraNoNCCs.InsertOnSubmit(chiTietPhieuTraNoNCC);
                        db.SubmitChanges();
                    }
                    ts.Complete();
                    return pPhieuTraNoNCC;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<eChiTietPhieuTraNoKhachHang> GetDSNoKhachHangDaTra()
        {
            List<eChiTietPhieuTraNoKhachHang> l = new List<eChiTietPhieuTraNoKhachHang>();
            foreach (ChiTietPhieuTraNoKhachHang chiTietPhieuTraNoKhachHang in db.ChiTietPhieuTraNoKhachHangs)
            {
                eChiTietPhieuTraNoKhachHang eChiTiet = new eChiTietPhieuTraNoKhachHang();
                eChiTiet.SoPhieuTraNo = chiTietPhieuTraNoKhachHang.SoPhieuTraNo;
                eChiTiet.MaSoCNKH = chiTietPhieuTraNoKhachHang.MaSoCNKH;
                eChiTiet.SoTien = chiTietPhieuTraNoKhachHang.SoTien;
                eChiTiet.GhiChu = chiTietPhieuTraNoKhachHang.GhiChu;
                l.Add(eChiTiet);
            }
            return l;
        }
        public List<eChiTietPhieuTraNoNCC> GetDSNoNCCDaTra()
        {
            List<eChiTietPhieuTraNoNCC> l = new List<eChiTietPhieuTraNoNCC>();
            foreach (ChiTietPhieuTraNoNCC chiTietPhieuTranoNCC in db.ChiTietPhieuTraNoNCCs)
            {
                eChiTietPhieuTraNoNCC eChiTiet = new eChiTietPhieuTraNoNCC();
                eChiTiet.SoPhieuTraNo = chiTietPhieuTranoNCC.SoPhieuTraNo;
                eChiTiet.MaSoCongNoNCC = chiTietPhieuTranoNCC.MaSoCongNoNCC;
                eChiTiet.SoTien = chiTietPhieuTranoNCC.SoTien;
                eChiTiet.GhiChu = chiTietPhieuTranoNCC.GhiChu;
                l.Add(eChiTiet);
            }
            return l;
        }
        public List<eCongNoKhachHang> GetListCongNoKH(string maKH)
        {
            List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
            foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.HoaDonBanSi.MaKH == maKH))
            {
                l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoKhachHang> GetListCongNoKH()
        {
            List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
            foreach (CongNoKH congNo in db.CongNoKHs)
            {
                l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoNCC> GetListCongNoNCC(string maNCC)
        {
            List<eCongNoNCC> l = new List<eCongNoNCC>();
            foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.HoaDonNhaCungCap.MaNhaCungCap == maNCC))
            {
                l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoNCC> GetListCongNoNCC()
        {
            List<eCongNoNCC> l = new List<eCongNoNCC>();
            foreach (CongNoNCC congNo in db.CongNoNCCs)
            {
                l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoKhachHang> GetListNoKHQuaHan()
        {
            List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
            foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 1))
            {
                l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoNCC> GetListNoNCCQuaHan()
        {
            List<eCongNoNCC> l = new List<eCongNoNCC>();
            foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 1))
            {
                l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoKhachHang> GetListNoKHToiHan()
        {
            List<eCongNoKhachHang> l = new List<eCongNoKhachHang>();
            foreach (CongNoKH congNo in db.CongNoKHs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 0))
            {
                l.Add(new eCongNoKhachHang(congNo.MaSoCNKH, congNo.MaHoaDonBanSi, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }
        public List<eCongNoNCC> GetListNoNCCToiHan()
        {
            List<eCongNoNCC> l = new List<eCongNoNCC>();
            foreach (CongNoNCC congNo in db.CongNoNCCs.Where(e => e.NgayDaoHan.CompareTo(DateTime.Now) == 0))
            {
                l.Add(new eCongNoNCC(congNo.MaSoCongNoNCC, congNo.MaHoaDonNCC, congNo.SoTienNo, congNo.NgayDaoHan, congNo.GhiChu));
            }
            return l;
        }

    }
}
