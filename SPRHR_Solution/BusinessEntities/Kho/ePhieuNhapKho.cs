using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class ePhieuNhapKho
    {
        private string _soPDNN, _maNV, _maKho, _ghiChu;
        private DateTime _ngayLap;

        public string SoPDNN
        {
            get
            {
                return _soPDNN;
            }

            set
            {
                _soPDNN = value;
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

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }

            set
            {
                _ghiChu = value;
            }
        }

        public ePhieuNhapKho()
        {
        }

        public ePhieuNhapKho(string _soPDNN, string _maNV, string _maKho, string _ghiChu, DateTime _ngayLap)
        {
            this._soPDNN = _soPDNN;
            this._maNV = _maNV;
            this._maKho = _maKho;
            this._ghiChu = _ghiChu;
            this._ngayLap = _ngayLap;
        }

        public override int GetHashCode()
        {
            return this._soPDNN.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            ePhieuNhapKho epn = (ePhieuNhapKho)obj;
            return epn._soPDNN.ToLower().Equals(_soPDNN.ToLower());
        }
    }
}
