using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Kho;
using BusinessEntities.Kho;
using BusinessEntities.PhongKeHoach;
using System.Windows.Forms;

namespace BusinessLogicTier.Kho
{
    public class PhieuXuatKho_BUS
    {
        PhieuXuatKho_dal pxBUS;
        public PhieuXuatKho_BUS()
        {
            pxBUS = new PhieuXuatKho_dal();
        }
        public List<ePhieuDeNghiXuatKho> GetPDNXK()
        {
            return pxBUS.GetPDNXK();
        }
        public List<ePhieuDeNghiXuatKho> GetPDNXKbyMa(string ma)
        {
            return pxBUS.GetPDNXKbyMa(ma);
        }
        public List<ePhieuXuatKho> GetPXK()
        {
            return pxBUS.GetPXK();
        }
        public List<ePhieuXuatKho> GetPXKbyMa(string ma)
        {
            return pxBUS.GetPXKbyMa(ma);
        }
        public int taophieuxuatkho(ePhieuXuatKho e)
        {
            return pxBUS.taophieuxuatkho(e);
        }
        public void LoadChiTiet(string maphieu, string makho, DataGridView dgv)
        {
            pxBUS.LoadChiTiet(maphieu, makho, dgv);
        }
    }
}
