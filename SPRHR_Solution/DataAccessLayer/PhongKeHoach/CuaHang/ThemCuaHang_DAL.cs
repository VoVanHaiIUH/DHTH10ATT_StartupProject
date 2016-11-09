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
        //Check Co Khong CuaHang
        //Get list CuaHang
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongCuaHang(string MaCuaHang)
        {
            var c = from i in db.DanhMucCuaHangs
                    where i.MaCuaHang == MaCuaHang
                    select i;
            if (c.Any())
            {
                return true;
            }
           throw new Exception("Không Tồn Tại Cửa Hàng Này");
        }
        public List<eCuaHang> GetALLCuaHang()
        {
            var c = from i in db.DanhMucCuaHangs
                    select i;
            List<eCuaHang> ls = new List<eCuaHang>();
            foreach(DanhMucCuaHang CH in c.ToList())
            {
                eCuaHang newcuahang = new eCuaHang();
                newcuahang.MaCuaHang = CH.MaCuaHang;
                newcuahang.TenCuaHang = CH.TenCuaHang;
                newcuahang.SoDienThoai = CH.SoDienThoai;
                newcuahang.DiaChi = CH.DiaChi;
                newcuahang.TinhTrang = CH.TinhTrang;
                ls.Add(newcuahang);
            }
            return ls;
        }
        // Insert CuaHang
        // Delete CuaHang
        // Fix Thong Tin CuaHang
        public void InsertCuaHang(eCuaHang CH)
        {
                DanhMucCuaHang CuaHang = new DanhMucCuaHang();
                CuaHang.MaCuaHang = TaoMaCuaHang();
                CuaHang.TenCuaHang = CH.TenCuaHang;
                CuaHang.DiaChi = CH.DiaChi;
                CuaHang.SoDienThoai = CH.SoDienThoai;
                CuaHang.TinhTrang = Convert.ToInt32(CH.SoDienThoai);
                db.DanhMucCuaHangs.InsertOnSubmit(CuaHang);
                db.SubmitChanges();            
        }
        public bool DeleteCuaHang(string MaCuaHang)
        {
            DanhMucCuaHang CH = db.DanhMucCuaHangs.Where(x => x.MaCuaHang == MaCuaHang).FirstOrDefault();
            if (CH != null)
            {
                db.DanhMucCuaHangs.DeleteOnSubmit(CH);
                db.SubmitChanges();
                return true;
            }
            throw new Exception("Cửa Hàng Không Có Sao Xóa");
        }
        public void FixCuaHang(string MaCuaHang, string TenCuaHang, string DiaChi, string SoDienThoai, int TinhTrang)
        {
            DanhMucCuaHang CH = db.DanhMucCuaHangs.Where(x => x.MaCuaHang == MaCuaHang).FirstOrDefault();
            if (CH != null)
            {
                CH.TenCuaHang = TenCuaHang;
                CH.DiaChi = DiaChi;
                CH.SoDienThoai = SoDienThoai;
                CH.TinhTrang = TinhTrang;
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Invaild ID");
            }
        }

        private string TaoMaCuaHang()
        {
            int max = 0;
            foreach (DanhMucCuaHang ch in db.DanhMucCuaHangs)
            {
                int t = int.Parse(ch.MaCuaHang.Substring(3));
                if (t >= max)
                    max = t;
            }
            max++;
            return "CH" + string.Format("{0:0000}", max);
        }
        public int CountSLCuaHang()
        {
            int n = db.DanhMucCuaHangs.Count();
            return n;
        }
    }   
}
