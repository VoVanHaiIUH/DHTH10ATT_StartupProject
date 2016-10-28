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

        public eThongTinKho(string _maKho, string _tenKho, string _diaChi, string _sDT)
        {
            this._maKho = _maKho;
            this._tenKho = _tenKho;
            this._diaChi = _diaChi;
            this._sDT = _sDT;
        }
    }
}
