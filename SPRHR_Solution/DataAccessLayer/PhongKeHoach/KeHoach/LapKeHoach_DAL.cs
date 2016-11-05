using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.KeHoach
{
    public class LapKeHoach_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public List<eKeHoach> DanhSachKeHoachChoSanPham(DateTime First, DateTime SeCond)
        {
            var Sp = from i in db.SanPhams
                     select i;
            List<eKeHoach> Ls = new List<eKeHoach>();
            foreach (SanPham SanPham in Sp.ToList())
            {
                eKeHoach Kh = new eKeHoach();
                Kh.MaSP = SanPham.MaSP;
                Kh.SLHangBan = 0;
                Kh.SLHangMua = 0;
                Kh.KeHoach += "Tình Trạng:";
                Ls.Add(Kh);
            }
            var HoaDonBanSi = from i in db.HoaDonBanSis
                              where i.NgayLap >= First && i.NgayLap <= SeCond
                              select i;
            foreach (HoaDonBanSi hd in HoaDonBanSi.ToList())
            {
                foreach (ChiTietHoaDonBanSi Ct in db.ChiTietHoaDonBanSis.Where(x => x.MaHoaDonBanSi == hd.MaHoaDonBanSi).ToList())
                {
                    foreach (eKeHoach KeH in Ls)
                    {
                        if (KeH.MaSP == Ct.MaSP)
                        {
                            KeH.SLHangBan += Convert.ToInt32(Ct.SoLuong);
                        }
                        else
                        {
                            KeH.SLHangBan = KeH.SLHangBan;
                        }
                    }
                }
            }
            var HoaDonBanHang = from i in db.HoaDonBanHangs
                                where i.ngayLap >= First && i.ngayLap <= SeCond
                                select i;
            foreach (HoaDonBanHang Hd in HoaDonBanHang.ToList())
            {
                foreach (ChiTietHoaDonBanHang Ct in db.ChiTietHoaDonBanHangs.Where(x => x.soHD == Hd.soHD).ToList())
                {
                    foreach (eKeHoach KeH in Ls)
                    {
                        if (KeH.MaSP == Ct.maSP)
                        {
                            KeH.SLHangBan += Convert.ToInt32(Ct.soLuong);
                        }
                        else
                        {
                            KeH.SLHangBan = KeH.SLHangBan;
                        }
                    }
                }
            }
            var HoaDonNhaCC = from i in db.HoaDonNhaCungCaps
                              where i.NgayLap >= First && i.NgayLap <= SeCond
                              select i;
            foreach (HoaDonNhaCungCap Hd in HoaDonNhaCC.ToList())
            {
                foreach (ChiTietHoaDonNhaCungCap Ct in db.ChiTietHoaDonNhaCungCaps.Where(x => x.MaHoaDonNhaCungCap == Hd.MaHoaDonNCC).ToList())
                {
                    foreach (eKeHoach Kh in Ls)
                    {
                        if (Kh.MaSP == Ct.MaSp)
                        {
                            Kh.SLHangMua += Convert.ToInt32(Ct.SoLuong);
                        }
                        else
                        {
                            Kh.SLHangMua = Kh.SLHangMua;
                        }
                    }
                }
            }
            foreach (eKeHoach Kh in Ls)
            {
                int Muc = Kh.SLHangMua - Kh.SLHangBan;
                if (Muc <= 0)
                {
                    Kh.KeHoach += "Ổn Định";
                }
                else
                {
                    if (Muc >= 1 && Muc <= 500)
                    {
                        Kh.KeHoach += "Cần Thêm Sản Phẩm";
                    }
                    else
                    {
                        if (Muc > 5000)
                        {
                            Kh.KeHoach += "Nhu Cầu Không Nhiều, Cần Khuyến Mãi Và Giảm Lượng Đặt Hàng";
                        }
                        else
                        {
                            Kh.KeHoach += "Ổn Định, Nên Xem Xét Khuyến Mãi";
                        }
                    }
                }
            }
            return Ls;
        }
    }
}
