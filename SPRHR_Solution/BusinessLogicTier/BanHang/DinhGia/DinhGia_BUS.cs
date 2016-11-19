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
        //Hiển thị bảng giá các sản phẩm đã được định giá
        public List<BusinessEntities.BanHang.eGiaBan> LoadGiaBan()
        {
            return db.LoadBangGia();
        }
        //Hiển thị danh sách các sản phẩm chưa được định giá
        public List<object> LoadSanPham()
        {
            return db.LoadListSP().ToList();
        }
        //Lấy thông tin về 1 Sản Phẩm 
        public object GetSP(string masp)
        {
            return db.GetSP(masp);
        }
    }
}
