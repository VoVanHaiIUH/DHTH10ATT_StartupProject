using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Kho;
using BusinessEntities.Kho;
using BusinessEntities.NhanSu;
namespace BusinessLogicTier.Kho
{
    public class QuanLyKho_BUS
    {
        QuanLyKho_dal qlkDAL;
        public QuanLyKho_BUS()
        {
            qlkDAL = new QuanLyKho_dal();
        }
        public List<eChucVu> GetChucVu()
        {
            return qlkDAL.GetChucVu();
        }
        public List<eChucVu> GetChucVubyMa(string ma)
        {
            return qlkDAL.GetChucVubyMa(ma);
        }
        public List<eThongTinKho> GetKho()
        {
            return qlkDAL.GetKho();
        }
        public List<eQuanLyKho> GetNv(string ma)
        {
            return qlkDAL.GetNv(ma);
        }
        public List<eNhanVien> GetTTNhanVien(string manv)
        {
            return qlkDAL.GetTTNhanVien(manv);
        }
        public int TaoNvKho(eQuanLyKho ql)
        {
            return qlkDAL.TaoNvKho(ql);
        }
        public bool XoaNVKho(string manv, string makho)
        {
            return qlkDAL.XoaNVKho(manv, makho);
        }
        public void SuaThongtinNvKho(eQuanLyKho update)
        {
            qlkDAL.SuaThongtinNvKho(update);
        }
    }
}
