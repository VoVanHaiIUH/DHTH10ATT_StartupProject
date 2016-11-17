using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.CongNo;
using BusinessEntities.CongNo;
using BusinessEntities.PhongKeHoach;

namespace BusinessLogicTier.CongNo
{
    public class CongNo_ALL_BUS
    {
        private CongNo_ALL_DAL CongNoDAL;
        public CongNo_ALL_BUS()
        {
            CongNoDAL = new CongNo_ALL_DAL();
        }
        public List<eKhachHang> GetListKhachHangNo()
        {
            return CongNoDAL.GetListKhachHangNo();
        }
        public List<eNhaCungCap> GetListNhaCungCapNo()
        {
            return CongNoDAL.GetListNhaCungCapNo();
        }
        public List<eCongNoNCC> GetListNoCuaNoCungCap(string pMaNhaCungCap)
        {
            return CongNoDAL.GetListNoCuaNoCungCap(pMaNhaCungCap);
        }
        public List<eCongNoKhachHang> GetListNoCuaNoKhachHang(string pMaKhachHang)
        {
            return CongNoDAL.GetListNoCuaNoKhachHang(pMaKhachHang);
        }

        public List<eChiTietPhieuTraNoNCC> GetChiTietTraNoNCC(string pMaHoaDon)
        {
            return CongNoDAL.GetListChiTietTraNoNCC(pMaHoaDon);
        }
        public List<eChiTietPhieuTraNoKhachHang> GetChiTietTraNoKH(string pMaHoaDon)
        {
            return CongNoDAL.GetListChiTietTraNoKH(pMaHoaDon);
        }
        public eChiTietPhieuTraNoNCC TraNoNCC(string pMaHoaDonNCC, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            return CongNoDAL.TraNoNCC(pMaHoaDonNCC, pMaNhanVien, pSoTien, pGhiChu);
        }
        public eChiTietPhieuTraNoKhachHang ThuNoKH(string pMaHoaDonBanSi, string pMaNhanVien, decimal pSoTien, string pGhiChu)
        {
            return CongNoDAL.ThuNoKH(pMaHoaDonBanSi, pMaNhanVien, pSoTien, pGhiChu);
        }
        public eCongNoNCC GhiNoNhaCungCap(string pMaHoaDonNCC, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            return CongNoDAL.GhiNoNhaCungCap(pMaHoaDonNCC, pSoTien, pNgayDaoHan, pGhiChu);
        }
        public eCongNoKhachHang GhiNoKhachHang(string pMaHoaDonBanSi, decimal pSoTien, DateTime pNgayDaoHan, string pGhiChu)
        {
            return CongNoDAL.GhiNoKhachHang(pMaHoaDonBanSi, pSoTien, pNgayDaoHan, pGhiChu);
        }
        ///// <summary>
        ///// Phương thức dùng để thêm mới công nợ khách hàng khi khách hàng mua hàng sĩ
        ///// nếu khách hàng thanh toán chưa đủ số tiền của hóa đơn
        ///// thì sẽ tự động gọi đến phương thức này để thêm công nợ
        ///// </summary>
        ///// <param name="maHoaDonBanSi">mã số hóa đơn mà khách hàng nợ</param>
        ///// <param name="soTienNo">số tiền khách hàng nợ</param>
        ///// <param name="ngayDaoHan">Ngày tới hạn phải trả nợ</param>
        ///// <param name="ghiChu">thông tin thêm về khoản nợ </param>
        ///// <returns>Thông tin chi tiết về khoản nợ đã được thêm</returns>
        //public eCongNoKhachHang ThemMoiCongNoKhachHang(string pMaHoaDonBanSi, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        //{
        //    // maHoaDonBanSi 
        //    // chắc chắn đã tạo hóa đơn bán sĩ rồi mới phát sinh dc nên mã luôn đúng
        //    // nếu cần kiểm tra thì cần hàm có chức năng kiểm tra xem hóa đơn bán sĩ có tồn tại hay không ở 
        //    // team Phòng kế hoạch
        //    // số tiền tương tự
        //    return CongNoDAL.ThemMoiCongNoKhachHang(pMaHoaDonBanSi, pSoTienNo, pNgayDaoHan, pGhiChu);
        //}
        ///// <summary>
        ///// Phương thức dùng để thêm mới công nợ nhà cung cấp khi mua hàng từ NCC
        ///// mà thanh toán chưa đủ số tiền của hóa đơn
        ///// thì sẽ tự động gọi đến phương thức này để thêm công nợ
        ///// </summary>
        ///// <param name="maHoaDonNCC">Mã hóa đơn mua hàng từ nhà cung cấp</param>
        ///// <param name="soTienNo">Số tiền mà mình nợ của nhà cung cấp</param>
        ///// <param name="ngayDaoHan">Ngày tới hạn phải trả nợ</param>
        ///// <param name="ghiChu">Thông tin thêm về khoản nợ</param>
        ///// <returns>Thông tin chi tiết về khoản nợ đã được thêm</returns>
        //public eCongNoNCC ThemMoiCongNoNCC(string pMaHoaDonNCC, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        //{
        //    return CongNoDAL.ThemMoiCongNoNCC(pMaHoaDonNCC, pSoTienNo, pNgayDaoHan, pGhiChu);
        //}
        ////public ePhieuTraNoKhachHang KhachHangTraNo(string pMaKH,DateTime pNgayTra,string pMaNhanVien,string pNoiDung, List<eChiTietPhieuTraNoKhachHang> pDSChiTietPhieuTraNo)
        ////{

        ////}
    }
}
