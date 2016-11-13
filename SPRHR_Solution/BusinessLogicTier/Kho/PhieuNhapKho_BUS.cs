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
        public List<ePhieuDeNghiNhapKho> GetPDNNK()
        {
            return pnkDAL.GetPDNNK();
        }
        public List<ePhieuDeNghiNhapKho> GetPDNNKbyMa(string ma)
        {
            return pnkDAL.GetPDNNKbyMa(ma);
        }
        public List<ePhieuNhapKho> getpnk()
        {
            return pnkDAL.GetPNK();
        }
        public List<ePhieuNhapKho> getpnktheoma(string ma)
        {
            return pnkDAL.GetPNKtheoMa(ma);
        }
        public IEnumerable<object> GetTTPhieuNhapKho(string maphieu)
        {
            return pnkDAL.GetTTPhieuNhapKho(maphieu);
        }
        public int taophieunhapkho(ePhieuNhapKho pnk)
        {
            return pnkDAL.TaoPNK(pnk);
        }
        public bool ktranv(string manv)
        {
            return pnkDAL.ktranv(manv);
        }
    }
}
