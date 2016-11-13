using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class eThongTinKho
    {
        private string _maKho, _tenKho, _diaChi, _sDT;

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
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

        public string SDT
        {
            get
            {
                return _sDT;
            }

            set
            {
                _sDT = value;
            }
        }

        public string TenKho
        {
            get
            {
                return _tenKho;
            }

            set
            {
                _tenKho = value;
            }
        }

        public eThongTinKho(string _maKho, string _tenKho, string _sDT, string _diaChi)
        {
            this._maKho = _maKho;
            this._tenKho = _tenKho;
            this._diaChi = _diaChi;
            this._sDT = _sDT;
        }

        public eThongTinKho()
        {

        }
    }
}
