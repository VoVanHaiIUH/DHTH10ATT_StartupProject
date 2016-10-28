using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class ePhieuNhapKho
    {
        private string _soPN, _soPDNN, _maNV, _maKho;
        private DateTime _ngayLap;

        public string soPN { get; set; }
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
                _ngayLap = DateTime.Now;
            }
        }
        //List<PhongKeHoach.ePhieuDNNK> listct;
        public ePhieuNhapKho(string _soPN, string _soPDNN, string _maNV, string _maKho, DateTime _ngayLap)
        {
            //this._soPN = "PNK" + DateTime.Now.ToString("yyyyMMdd")+"-" + (stt + 1).ToString();
            this._soPN = _soPN;
            this._soPDNN = _soPDNN;
            this._maNV = _maNV;
            this._maKho = _maKho;
            this._ngayLap = _ngayLap;
            //listct = new List<PhongKeHoach.ePhieuDNNK>();
        }
        public override int GetHashCode()
        {
            return this._soPN.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            ePhieuNhapKho epn = (ePhieuNhapKho)obj;
            return epn._soPN.ToLower().Equals(_soPN.ToLower());
        }
    }
}
