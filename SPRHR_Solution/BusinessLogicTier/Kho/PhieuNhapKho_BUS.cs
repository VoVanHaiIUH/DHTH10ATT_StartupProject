using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Kho;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
namespace BusinessLogicTier.Kho
{
    public class PhieuNhapKho_BUS
    {
        PhieuNhapKho_dal pnkDAL;
        public PhieuNhapKho_BUS()
        {
            pnkDAL = new PhieuNhapKho_dal();
        }
        public List<ePhieuNhapKho> getpnk()
        {
            return pnkDAL.getpnk();
        }
        public List<ePhieuNhapKho> getpnktheoma(string ma)
        {
            return pnkDAL.getpnktheoma(ma);
        }
        public List<DataAccessLayer.SanPham> getSPtheosoPDNN(string maphieu)
        {
            return pnkDAL.getSPtheosoPDNN(maphieu);
        }
        public int taophieunhapkho(ePhieuNhapKho pnk)
        {
            return pnkDAL.taophieunhapkho(pnk);
        }
    }
}
