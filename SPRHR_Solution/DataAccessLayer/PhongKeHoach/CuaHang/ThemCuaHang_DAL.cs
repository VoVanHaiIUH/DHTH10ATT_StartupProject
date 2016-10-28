using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.CuaHang
{
    public class ThemCuaHang_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongCuaHang(string MaCuaHang)
        {
            var c = from i in db.DanhMucCuaHangs
                    where i.MaCuaHang == MaCuaHang
                    select i;
            if(c.Any())
            {
                return true;
            }
            return false;
        }
        // Insert CuaHang
        // Delete CuaHang
        // Fix Thong Tin CuaHang
        public bool InsertCuaHang(eCuaHang CH)
        {
            var c = from i in db.DanhMucCuaHangs
                    where i.MaCuaHang == CH.MaCuaHang
                    select i;
            if(c.Any())
            {
                return false;
            }
            else
            {
                DanhMucCuaHang CuaHang = new DanhMucCuaHang();
                CuaHang.MaCuaHang = CH.MaCuaHang;
                CuaHang.TenCuaHang = CH.TenCuaHang;
                CuaHang.DiaChi = CH.DiaChi;
                CuaHang.SoDienThoai = CH.SoDienThoai;
                CuaHang.TinhTrang = Convert.ToInt32(CH.SoDienThoai);
                db.DanhMucCuaHangs.InsertOnSubmit(CuaHang);
                db.SubmitChanges();
                return true;
            }
        }
        public bool DeleteCuaHang(string MaCuaHang)
        {
            DanhMucCuaHang CH = db.DanhMucCuaHangs.Where(x => x.MaCuaHang == MaCuaHang).FirstOrDefault();
            if(CH != null)
            {
                db.DanhMucCuaHangs.DeleteOnSubmit(CH);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public void FixCuaHang(string MaCuaHang,string TenCuaHang,string DiaChi,string SoDienThoai,int TinhTrang)
        {

        }
    }
}
