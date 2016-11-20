using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BanHang
{
    public class ePhuongThucThanhToan
    {
        private string _maPhuongThuc;

        public string MaPhuongThuc
        {
            get { return _maPhuongThuc; }
            set { _maPhuongThuc = value; }
        }

        private string _tenPhuongThuc;

        public string TenPhuongThuc
        {
            get { return _tenPhuongThuc; }
            set { _tenPhuongThuc = value; }
        }

        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }

        public ePhuongThucThanhToan(string pMaPt,string pTenPt)
        {
            this._maPhuongThuc = pMaPt;
            this._tenPhuongThuc = pTenPt;
        }
    }
}
