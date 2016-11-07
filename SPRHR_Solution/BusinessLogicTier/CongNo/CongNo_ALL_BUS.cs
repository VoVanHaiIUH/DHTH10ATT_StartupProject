using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.CongNo;
using BusinessEntities.CongNo;

namespace BusinessLogicTier.CongNo
{
    public class CongNo_ALL_BUS
    {
        private CongNo_ALL_DAL CongNoDAL = new CongNo_ALL_DAL();
        /// <summary>
        /// Phương thức dùng để thêm mới công nợ khách hàng khi khách hàng mua hàng sĩ
        /// nếu khách hàng thanh toán chưa đủ số tiền của hóa đơn
        /// thì sẽ tự động gọi đến phương thức này để thêm công nợ
        /// </summary>
        /// <param name="maHoaDonBanSi">mã số hóa đơn mà khách hàng nợ</param>
        /// <param name="soTienNo">số tiền khách hàng nợ</param>
        /// <param name="ngayDaoHan">Ngày tới hạn phải trả nợ</param>
        /// <param name="ghiChu">thông tin thêm về khoản nợ </param>
        /// <returns>Thông tin chi tiết về khoản nợ đã được thêm</returns>
        public eCongNoKhachHang ThemMoiCongNoKhachHang(string pMaHoaDonBanSi, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        {
            // maHoaDonBanSi 
            // chắc chắn đã tạo hóa đơn bán sĩ rồi mới phát sinh dc nên mã luôn đúng
            // nếu cần kiểm tra thì cần hàm có chức năng kiểm tra xem hóa đơn bán sĩ có tồn tại hay không ở 
            // team Phòng kế hoạch
            // số tiền tương tự
            return CongNoDAL.ThemMoiCongNoKhachHang(pMaHoaDonBanSi, pSoTienNo, pNgayDaoHan, pGhiChu);
        }
        /// <summary>
        /// Phương thức dùng để thêm mới công nợ nhà cung cấp khi mua hàng từ NCC
        /// mà thanh toán chưa đủ số tiền của hóa đơn
        /// thì sẽ tự động gọi đến phương thức này để thêm công nợ
        /// </summary>
        /// <param name="maHoaDonNCC">Mã hóa đơn mua hàng từ nhà cung cấp</param>
        /// <param name="soTienNo">Số tiền mà mình nợ của nhà cung cấp</param>
        /// <param name="ngayDaoHan">Ngày tới hạn phải trả nợ</param>
        /// <param name="ghiChu">Thông tin thêm về khoản nợ</param>
        /// <returns>Thông tin chi tiết về khoản nợ đã được thêm</returns>
        public eCongNoNCC ThemMoiCongNoNCC(string pMaHoaDonNCC, decimal pSoTienNo, DateTime pNgayDaoHan, string pGhiChu)
        {
            return CongNoDAL.ThemMoiCongNoNCC(pMaHoaDonNCC, pSoTienNo, pNgayDaoHan, pGhiChu);
        }
        //public ePhieuTraNoKhachHang KhachHangTraNo(string pMaKH,DateTime pNgayTra,string pMaNhanVien,string pNoiDung, List<eChiTietPhieuTraNoKhachHang> pDSChiTietPhieuTraNo)
        //{

        //}
    }
}
