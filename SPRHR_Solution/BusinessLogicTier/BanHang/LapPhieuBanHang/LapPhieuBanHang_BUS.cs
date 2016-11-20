using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BanHang;
using DataAccessLayer.BanHang.LapPhieuBanHang;
using System.Reflection;

namespace BusinessLogicTier.BanHang.LapPhieuBanHang
{
    public class LapPhieuBanHang_BUS
    {
        DataAccessLayer.BanHang.LapPhieuBanHang.LapPhieuBanHang_DAL db;
        List<object> lList;
        public LapPhieuBanHang_BUS()
        {
            db = new LapPhieuBanHang_DAL();
            lList = new List<object>();
        }
        /// <summary>
        /// Hiển thị thông tin giỏ hàng hiện tại
        /// </summary>
        /// <returns></returns>
        public List<object> GioHang()
        {
            return lList.ToList();
        }
        /// <summary>
        /// Kiểm tra Nhân Viên lập hóa đơn có tồn tại không
        /// </summary>
        /// <param name="pMaNV">Mã nhân viên cần kiểm tra</param>
        /// <returns>Nếu có tồn tại thì trả về true và ngược lại</returns>
        public bool TestNV(string pMaNV)
        {
            return db.TestNV(pMaNV);
        }
        /// <summary>
        /// Kiểm tra Khách Hàng có tạo thẻ thành viên chưa
        /// </summary>
        /// <param name="pMaKh">Mã khách hàng cần kiểm tra</param>
        /// <returns>Nếu có tồn tại thì trả về true và ngược lại</returns>
        public bool TestKH(string pMaKh)
        {
            return db.TestKH(pMaKh);
        }
        /// <summary>
        /// Lấy thông tin khuyến mãi của sản phẩm
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần kiểm tra</param>
        /// <returns>Giá khuyến mãi của sản phẩm</returns>
        public decimal GetCTKM(string pMaSp)
        {
            return db.TestKM(pMaSp);
        }
        /// <summary>
        /// Tìm sản phẩm trên bảng giá
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần tìm</param>
        /// <param name="pSl">Số lượng sản phẩm cần mua</param>
        /// <param name="pGiaKm">Giá khuyến mại cho sản phẩm tương ứng</param>
        /// <returns>Chi tiết hóa đơn cần sử dụng</returns>
        public object SearchSP(string pMaSp, short pSl,decimal pGiaKm)
        {
            return db.SearchSP(pMaSp, pSl, pGiaKm);
        }
        /// <summary>
        /// Thêm sản phẩm vào giỏ hàng hiện tại
        /// </summary>
        /// <param name="pCtHD">Chi tiết hóa đơn cần thêm vào</param>
        public void AddList(object pCtHD)
        {
            foreach (var item in lList)
            {
                PropertyInfo piP = item.GetType().GetProperty("MaSP");
                if (piP.GetValue(item).ToString() == piP.GetValue(pCtHD).ToString())
                {
                    PropertyInfo piD = item.GetType().GetProperty("sl");
                    string MaSP = piP.GetValue(item).ToString();
                    string TenSp = item.GetType().GetProperty("TenSp").GetValue(item).ToString();
                    decimal giaBan = decimal.Parse(item.GetType().GetProperty("giaBan").GetValue(item).ToString());
                    decimal giakm = decimal.Parse(item.GetType().GetProperty("giakm").GetValue(item).ToString());
                    int sl = short.Parse(piD.GetValue(item).ToString()) + short.Parse(piD.GetValue(pCtHD).ToString());
                    var obj = new
                    {
                        MaSP,
                        TenSp,
                         sl,
                         giaBan,
                         giakm,
                    };
                    lList.Remove(item);
                    lList.Add(obj);
                    return;
                }
            }
            lList.Add(pCtHD);
        }
        /// <summary>
        /// Bỏ 1 sản phẩm ra khỏi giỏ hàng
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần bỏ</param>
        public void DeleteList(string pMaSp)
        {
            foreach (var item in lList)
            {
              PropertyInfo pP = item.GetType().GetProperty("MaSP");
              if (pP.GetValue(item).ToString() == pMaSp)
              {
                  lList.Remove(item);
                  return;
              }
            }           
        }
        /// <summary>
        /// Tính tổng tiền hóa đơn
        /// </summary>
        /// <returns>Tổng tiền của Hóa Đơn</returns>
        public decimal TongTien()
        {
            decimal dcmTongTien = 0;
            foreach (var item in lList)
            {
                PropertyInfo piSL = item.GetType().GetProperty("sl");
                PropertyInfo piDG = item.GetType().GetProperty("giaBan");
                dcmTongTien += decimal.Parse(piSL.GetValue(item).ToString()) * decimal.Parse(piDG.GetValue(item).ToString());
            }
            return dcmTongTien;
        }
        /// <summary>
        /// Lấy từ cơ sở dữ liệu danh sách các phương thúc thanh toán
        /// </summary>
        /// <returns>Danh sách các phương thức thanh toán</returns>
        public List<BusinessEntities.BanHang.ePhuongThucThanhToan> LoadPT()
        {
            return db.LoadPT();
        }
    }
}
