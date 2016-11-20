using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;

namespace DataAccessLayer.BanHang.DinhGia
{
    public class DinhGia_DAL
    {
        SPRHR_SolutionDataContext db;
        public DinhGia_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }

        public List<BusinessEntities.BanHang.eGiaBan> LoadBangGia()
        {
            var linq = from gb in db.BangGiaBans
                       select gb;
            List<BusinessEntities.BanHang.eGiaBan> list = new List<BusinessEntities.BanHang.eGiaBan>();
            foreach (var item in linq.ToList())
            {
                BusinessEntities.BanHang.eGiaBan temp = new BusinessEntities.BanHang.eGiaBan(item.maSP, item.giaBan, item.ngayApDung);
                list.Add(temp);
            }
            return list;
        }
        public IEnumerable<object> LoadListSP()
        {
            try
            {
                var query = (from sp in db.SanPhams
                             where !db.BangGiaBans.Any(e => e.maSP == sp.MaSP)
                             select new
                             {
                                 sp.MaSP,
                                 sp.LoaiSanPham.TenLoaiSanPham,
                                 sp.TenSp,
                             });
                return query;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public object GetSP(string masp)
        {
            try
            {
                var linq = (from sp in db.SanPhams
                            where sp.MaSP == masp
                            select new
                            {
                                sp.MaSP,
                                sp.TenSp,
                                sp.LoaiSanPham.TenLoaiSanPham,
                                sp.MauSac,
                                sp.TrongLuong,
                                sp.DonViTinh,
                                sp.NgayHetHan,
                                sp.NgaySanXuat,
                            }).First();
                return linq;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Cập nhật số tiền nhập từ nhà cung cấp của sản phẩm gần nhất
        /// </summary>
        /// <param name="masp">Mã sản phẩm cần cập nhật</param>
        /// <returns>Số tiền mua từ nhà cung cấp trong hóa đơn gần nhất</returns>
        public decimal GetHDNCC(string masp)
        {
            try
            {
                var linq = (from gm in db.ChiTietHoaDonNhaCungCaps
                            where gm.MaSPNCC == masp
                            select new
                            {
                                gm.GiaMuaBenNhaCungCap,
                            });
                return linq.ToList().Last().GiaMuaBenNhaCungCap;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// Cập nhật giá mới nhất cho sản phẩm
        /// </summary>
        /// <param name="masp">Mã sản phẩm cần định giá</param>
        /// <param name="giamoi">Giá tiền cập nhật</param>
        /// <returns></returns>
        public bool UpdateBangGia(string masp, decimal giamoi)
        {
            try
            {
                db.Connection.Open();
                System.Data.Common.DbTransaction transaction = db.Connection.BeginTransaction();
                db.Transaction = transaction;
                var linq = (from gb in db.BangGiaBans
                            where gb.maSP == masp
                            select gb).First();
                linq.giaBan = giamoi;
                linq.ngayApDung = DateTime.Now;
                db.SubmitChanges();
                db.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                db.Transaction.Rollback();
                return false;
            }
        }
    }
}
