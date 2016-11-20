using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.BanHang;

namespace DataAccessLayer.BanHang.LapPhieuBanHang
{
    public class LapPhieuBanHang_DAL
    {
        SPRHR_SolutionDataContext db;
        public LapPhieuBanHang_DAL()
        {
            db = new SPRHR_SolutionDataContext();
        }
        /// <summary>
        /// Kiểm tra chương trình khuyến mãi của sản phẩm
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần kiểm tra</param>
        /// <returns>Giá khuyến mãi của sản phẩm đó</returns>
        public decimal TestKM(string pMaSp)
        {
            try
            {
                var vCtKm = (from km in db.ChiTietKhuyenMais
                            where km.MaSp == pMaSp
                            select new
                            {
                                km.ChuongTrinhKhuyenMai.NgayKetThuc,
                                km.GiaKhuyenMai,
                            }).FirstOrDefault();
                if (DateTime.Now <= vCtKm.NgayKetThuc)
                    return vCtKm.GiaKhuyenMai;
                else return 0;
            }
            catch (Exception)
            {
                return 0;
            }
                
        }
        /// <summary>
        /// Tìm kiếm sản phẩm trên bảng giá
        /// </summary>
        /// <param name="pMaSp">Mã sản phẩm cần tìm kiếm</param>
        /// <param name="pSl">Số lượng sản phẩm cần trả về</param>
        /// <param name="pGiaKm">Giá khuyến mãi cho sản phẩm đó</param>
        /// <returns>Sản phẩm cần tìm</returns>
        public object SearchSP(string pMaSp, short pSl, decimal pGiaKm)
        {
            try
            {
                var vQuery = db.SanPhams.Where(e => e.MaSP == pMaSp).Select(x => new
                {
                    x.MaSP,
                    x.TenSp,
                    sl = pSl,
                    x.BangGiaBan.giaBan,
                    giakm = pGiaKm,
                }).FirstOrDefault();
                return vQuery;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool TestNV(string pMaNV)
        {
            var vLinq = (from nv in db.NhanViens
                        where nv.maNhanVien == pMaNV
                        select nv).Count();
            if (vLinq == 0) return false;
            return true;
        }

        public bool TestKH(string pMaKh)
        {
            var vLinq = (from kh in db.KhachHangs
                        where kh.MaKH == pMaKh
                        select kh).Count();
            if (vLinq == 0) return false;
            return true;
        }

        public List<BusinessEntities.BanHang.ePhuongThucThanhToan> LoadPT()
        {
            var vLinq = from pt in db.PhuongThucThanhToans
                       select pt;
            List<BusinessEntities.BanHang.ePhuongThucThanhToan> lList = new List<BusinessEntities.BanHang.ePhuongThucThanhToan>();
            foreach (var item in vLinq.ToList())
            {
                BusinessEntities.BanHang.ePhuongThucThanhToan temp = new BusinessEntities.BanHang.ePhuongThucThanhToan(item.maPhuongThuc, item
                    .tenPhuongThuc);
                lList.Add(temp);
            }
            return lList;
        }
    }
}
