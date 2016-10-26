using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class eQuanLyKho
    {
        private string _maKho, _maNV, _chucVu;
        private DateTime _thoiGianBD, _thoiGianKT;

        public string ChucVu
        {
            get
            {
                return _chucVu;
            }

            set
            {
                _chucVu = value;
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

        public DateTime ThoiGianBD
        {
            get
            {
                return _thoiGianBD;
            }

            set
            {
                _thoiGianBD = value;
            }
        }

        public DateTime ThoiGianKT
        {
            get
            {
                return _thoiGianKT;
            }

            set
            {
                _thoiGianKT = value;
            }
        }

        public eQuanLyKho(string _maKho, string _maNV, string _chucVu, DateTime _thoiGianBD, DateTime _thoiGianKT)
        {
            this._maKho = _maKho;
            this._maNV = _maNV;
            this._chucVu = _chucVu;
            this._thoiGianBD = _thoiGianBD;
            this._thoiGianKT = _thoiGianKT;
        }
        public eQuanLyKho()
        {

        }
    }
}
