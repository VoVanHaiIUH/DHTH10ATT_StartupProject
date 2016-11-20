using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BanHang
{
    public class eThanhToan
    {
        private string _soHD;

        public string SoHD
        {
            get { return _soHD; }
            set { _soHD = value; }
        }

        private decimal _tien;

        public decimal Tien
        {
            get { return _tien; }
            set { _tien = value; }
        }

        private string _maPhuongThuc;

        public string MaPhuongThuc
        {
            get { return _maPhuongThuc; }
            set { _maPhuongThuc = value; }
        }

        public eThanhToan(decimal pTien,string pMaPThuc)
        {
            this._tien = pTien;
            this._maPhuongThuc = pMaPThuc;
        }
    }
}
