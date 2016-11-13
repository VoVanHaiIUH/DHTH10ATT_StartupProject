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

        

        public eQuanLyKho(string _maKho, string _maNV, string _chucVu)
        {
            this._maKho = _maKho;
            this._maNV = _maNV;
            this._chucVu = _chucVu;
        }
        public eQuanLyKho()
        {

        }
        public override int GetHashCode()
        {
            return this._maKho.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            eQuanLyKho epn = (eQuanLyKho)obj;
            return epn._maKho.ToLower().Equals(_maKho.ToLower());
        }
    }
}
