using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BanHang;
using DataAccessLayer.BanHang.LapPhieuBanHang;

namespace BusinessLogicTier.BanHang.LapPhieuBanHang
{
    public class LapPhieuBanHang_BUS
    {
        LapPhieuBanHang_DAL db;
        public LapPhieuBanHang_BUS()
        {
            db = new LapPhieuBanHang_DAL();
        }
        //Kiểm tra Nhân Viên lập hóa đơn có tồn tại không
        public bool TestNV(string manv)
        {
            return db.ktranhvien(manv);
        }
        //Kiểm tra Khách Hàng có tạo thẻ thành viên chưa
        public bool TestKH(string makh)
        {
            return db.ktrakhhang(makh);
        }
        //Tìm sản phẩm trên bảng giá
        public BusinessEntities.BanHang.eGiaBan SearchSP(string masp)
        {
            return db.SearchSP(masp);
        }
        //public bool themHoaDon(eHoaDonBanHang hd)
        //{
        //    DateTime temp = DateTime.Now;
        //    if (!db.ktrakhhang(hd.MaKH) || !db.ktranhvien(hd.MaNV) || hd.NgayLap > temp)
        //        return false;
        //    if (hd.Count() < 1 || hd.Count() > 50)
        //        return false;
        //    db.themHoaDon(hd.MaNV, hd.MaKH, hd.NgayLap, hd.TongTien, hd.VAT);
        //    return true;
        //}
    }
}
