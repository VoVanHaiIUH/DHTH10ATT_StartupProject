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
            var vLinq = from gb in db.BangGiaBans
                       select gb;
            List<BusinessEntities.BanHang.eGiaBan> lList = new List<BusinessEntities.BanHang.eGiaBan>();
            foreach (var item in vLinq.ToList())
            {
                BusinessEntities.BanHang.eGiaBan egbTemp = new BusinessEntities.BanHang.eGiaBan(item.maSP, item.giaBan, item.ngayApDung);
                lList.Add(egbTemp);
            }
            return lList;
        }
        public IEnumerable<object> LoadListSP()
        {
            try
            {
                var vQuery = (from sp in db.SanPhams
                             where !db.BangGiaBans.Any(e => e.maSP == sp.MaSP)
                             select new
                             {
                                 sp.MaSP,
                                 sp.LoaiSanPham.TenLoaiSanPham,
                                 sp.TenSp,
                             });
                return vQuery;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public object GetSP(string pMaSp)
        {
            try
            {
                var vLinq = (from sp in db.SanPhams
                            where sp.MaSP == pMaSp
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
                return vLinq;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// Cập nhật số tiền nhập từ nhà cung cấp của sản phẩm gần nhất
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần cập nhật</param>
        /// <returns>Số tiền mua từ nhà cung cấp trong hóa đơn gần nhất</returns>
        public decimal GetHDNCC(string pMaSp)
        {
            try
            {
                var vLinq = (from gm in db.ChiTietHoaDonNhaCungCaps
                            where gm.MaSPNCC == pMaSp
                            select new
                            {
                                gm.GiaMuaBenNhaCungCap,
                            });
                return vLinq.ToList().Last().GiaMuaBenNhaCungCap;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        /// <summary>
        /// Cập nhật giá mới nhất cho sản phẩm
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần định giá</param>
        /// <param name="pGiaMoi">Giá tiền cập nhật</param>
        /// <returns></returns>
        public bool UpdateBangGia(string pMaSp, decimal pGiaMoi)
        {
            try
            {
                db.Connection.Open();
                System.Data.Common.DbTransaction tTransaction = db.Connection.BeginTransaction();
                db.Transaction = tTransaction;
                var vLinq = (from gb in db.BangGiaBans
                            where gb.maSP == pMaSp
                            select gb).First();
                vLinq.giaBan = pGiaMoi;
                vLinq.ngayApDung = DateTime.Now;
                db.SubmitChanges();
                db.Transaction.Commit();
                db.Connection.Close();
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
