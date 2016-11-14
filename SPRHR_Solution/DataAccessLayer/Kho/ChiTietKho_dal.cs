using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
namespace DataAccessLayer.Kho
{
    public class ChiTietKho_dal
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();

        public List<eChiTietKho> GetSpByMakho(string makho)
        {
            List<eChiTietKho> ls = new List<eChiTietKho>();
            foreach (ChiTietKho item in db.ChiTietKhos.Where(e => e.maKho == makho))
            {
                ls.Add(new eChiTietKho(item.maSP, item.maKho,  (int)item.soLuong));
            }
            return ls;
        }

        public List<eSanPham> GetThongTinSp(string masp)
        {
            List<eSanPham> ls = new List<eSanPham>();
            foreach(SanPham s in db.SanPhams.Where(e=>e.MaSP == masp))
            {
                eSanPham t = new eSanPham();
                t.TenSP = s.TenSp;
                t.MaLoaiSP = s.MaLoaiSanPham;
                t.MoTa = s.Mota;

                ls.Add(t);
            }
            return ls;
        }
    }
}
