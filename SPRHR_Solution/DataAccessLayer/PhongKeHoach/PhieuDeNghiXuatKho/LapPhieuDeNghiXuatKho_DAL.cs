using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.PhieuDeNghiXuatKho
{
    public class LapPhieuDeNghiXuatKho_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongPhieuDNXK(string SoPhieu)
        {
            var c = from i in db.PhieuDNXKs
                    where i.MaPhieuDNXK == SoPhieu
                    select i;
            if(c.Any())
            {
                return true;
            }
            return false;
        }
        // Tao PDNXK
        // Tao chi tiet PDNXK
        // Delete PDNXK
        // Delete chi tiet PDNXK
        // ....
        // ....
        //.........>>
        public int InsertPDNXK(ePhieuDeNghiXuatKho Phieu)
        {
            
        }
        public int InsertPDNXKChiTiet(eChiTietPhieuDeNghiXuatKho Chitiet)
        {

        }
        public bool DeLetePDNXK(string SoPhieu)
        {

        }
        public bool DeletePDNXKChiTiet(string SoPhieu, string MaSP)
        {

        }
    }
}
