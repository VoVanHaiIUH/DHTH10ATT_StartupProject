using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
using System.Windows.Forms;
namespace DataAccessLayer.Kho
{
    public class ChiTietKho_dal
    {
        
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();

        public void search(string makho, string tensp, DataGridView dgv)
        {
            var ls = from i in db.ChiTietKhos
                     where i.maKho == makho
                     from e in db.SanPhams
                     where e.TenSp.Contains(tensp) && e.MaSP == i.maSP
                     select new
                     {
                         i.maSP,
                         e.TenSp,
                         i.soLuong,
                         e.MauSac,
                         e.NgaySanXuat,
                         e.NgayHetHan,
                     };
            dgv.DataSource = ls.ToList();
        }
        public List<eChiTietKho> GetSpByMakho(string makho)
        {
            List<eChiTietKho> ls = new List<eChiTietKho>();
            foreach (ChiTietKho item in db.ChiTietKhos.Where(e => e.maKho == makho))
            {
                ls.Add(new eChiTietKho(item.maSP, item.maKho, (int)item.soLuong));
            }
            return ls;
        }

        public List<eSanPham> GetThongTinSp(string masp)
        {
            List<eSanPham> ls = new List<eSanPham>();
            foreach (SanPham s in db.SanPhams.Where(e => e.MaSP == masp))
            {
                eSanPham t = new eSanPham();
                t.TenSP = s.TenSp;
                t.MaLoaiSP = s.MaLoaiSanPham;
                t.MauSac = s.MauSac;
                t.NgaySX = s.NgaySanXuat;

                ls.Add(t);
            }
            return ls;
        }
        //public void GetTTSP(string makho, DataGridView dgv)
        //{
        //    var ls = from i in db.ChiTietKhos
        //             where i.maKho == makho
        //             from e in db.SanPhams
        //             where e.MaSP == i.maSP
        //             select new
        //             {
        //                 i.maSP,
        //                 e.TenSp,
        //                 i.soLuong,
        //                 e.MauSac,
        //                 e.NgaySanXuat,
        //             };
        //    dgv.DataSource = ls.ToList();
        //}

        //public List<eChiTietKho> search(string makho, string tensp)
        //{
        //    List<eChiTietKho> ls = new List<eChiTietKho>();
        //    foreach (ChiTietKho ctk in db.ChiTietKhos.Where(k => k.maKho == makho))
        //    {
        //        foreach (SanPham sp in db.SanPhams.Where(s => s.TenSp.StartsWith(tensp) && s.MaSP == ctk.maSP))
        //        {
        //            ls.Add(new eChiTietKho(ctk.maSP, ctk.maKho, (int)ctk.soLuong));
        //        }
        //    }
        //    return ls;
        //}


    }

}
