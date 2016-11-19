using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                             where !db.BangGiaBans.Any(e=>e.maSP==sp.MaSP)
                             select new {
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
        public  object GetSP(string masp)
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
                                sp.MauSac,sp.TrongLuong,sp.DonViTinh,
                                sp.NgayHetHan,sp.NgaySanXuat,
                            }).First();
                return linq;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
