using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.PhongKeHoach;

namespace DataAccessLayer.PhongKeHoach.PhieuDeNghiNhapKho
{
    public class LapPhieuDeNghiNhapKho_DAL
    {
        SPRHR_SolutionDataContext db = new SPRHR_SolutionDataContext();
        public bool CheckCoKhongPDNNK(string SoPhieu)
        {
            var c = from i in db.PhieuDNNKs
                    where i.MaPhieuDNNK == SoPhieu
                    select i;
            if (c.Any())
            {
                return true;
            }
            else return false;
        }
        // Tao PDNNK
        // Tao chi tiet PDNNK
        // Delete PDNNK
        // Delete chi tiet PDNNK
        // ....
        // ....
        //.........>>
        public int InsertPDNNK(ePhieuDeNghiNhapKho Phieu)
        {
            
        }
        public int InsertPDNNKChiTiet(eChiTietPhieuDeNghiNhapKho Chitiet)
        {

        }
        public bool DeLetePDNNK(string SoPhieu)
        {

        }
        public bool DeletePDNNKChiTiet(string SoPhieu,string MaSP)
        {

        }
    }
}
