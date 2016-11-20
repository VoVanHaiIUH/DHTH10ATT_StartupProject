using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier.BanHang.DinhGia
{
    public class DinhGia_BUS
    {
        DataAccessLayer.BanHang.DinhGia.DinhGia_DAL db;
        public DinhGia_BUS()
        {
            db = new DataAccessLayer.BanHang.DinhGia.DinhGia_DAL();
        }
        /// <summary>
        /// Hiển thị bảng giá các sản phẩm đã được định giá
        /// </summary>
        /// <returns>Danh sách các sản phẩm đã được định giá</returns>
        public List<BusinessEntities.BanHang.eGiaBan> LoadGiaBan()
        {
            return db.LoadBangGia();
        }
        /// <summary>
        /// Hiển thị danh sách các sản phẩm chưa được định giá
        /// </summary>
        /// <returns>Danh sách các sản phẩm chưa được định giá</returns>
        public List<object> LoadSanPham()
        {
            return db.LoadListSP().ToList();
        }
        /// <summary>
        /// Lấy thông tin về 1 Sản Phẩm 
        /// </summary>
        /// <param name="masp">Mã sản phẩm cần tìm</param>
        /// <returns>1 Sản phẩm</returns>
        public object GetSP(string masp)
        {
            return db.GetSP(masp);
        }
        /// <summary>
        /// Định giá sản phẩm
        /// </summary>
        /// <param name="masp"></param>
        public bool DinhGiaSP(string masp)
        {
            decimal giamua = db.GetHDNCC(masp);
            if (giamua == -1)
            {
                System.Windows.Forms.MessageBox.Show("Không tìm thấy Hóa Đơn Nhà cung cấp nào tương ứng với sản phẩm", "Lỗi Database", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            decimal dinhgia = (giamua * 10 / 100) + giamua;
            return db.UpdateBangGia(masp, dinhgia);
        }
    }
}
