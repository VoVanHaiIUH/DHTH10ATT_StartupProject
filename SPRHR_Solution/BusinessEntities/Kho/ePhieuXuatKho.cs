using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class ePhieuXuatKho
    {
        private string _soPX, _soPDNX, _maNV, _maKho;
        private DateTime _ngayLap;

        public string SoPX
        {
            get
            {
                return _soPX;
            }

            set
            {
                _soPX = value;
            }
        }

        public string SoPDNX
        {
            get
            {
                return _soPDNX;
            }

            set
            {
                _soPDNX = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public string MaKho
        {
            get
            {
                return _maKho;
            }

            set
            {
                _maKho = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return _ngayLap;
            }

            set
            {
                _ngayLap = value;
            }
        }
        public ePhieuXuatKho(string _soPX, string _soPDNX, string _maNV, string _maKho, DateTime _ngayLap)
        {
            this._soPX = _soPX;
            this._soPDNX = _soPDNX;
            this._maNV = _maNV;
            this._maKho = _maKho;
            this._ngayLap = _ngayLap;
        }
        public override bool Equals(object obj)
        {
            ePhieuXuatKho epx = (ePhieuXuatKho)obj;
            return epx._soPX.ToLower().Equals(_soPX.ToLower());
        }
        public override int GetHashCode()
        {
            return this._soPX.GetHashCode();
        }
    }
}
