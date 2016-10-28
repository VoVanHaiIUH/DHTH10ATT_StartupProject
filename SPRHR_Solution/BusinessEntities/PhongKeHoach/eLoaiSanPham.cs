using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eLoaiSanPham
    {
        private string _MaLoaiSP, _TenLoaiSP, _MoTa, _Style;

        public string MaLoaiSP
        {
            get
            {
                return _MaLoaiSP;
            }

            set
            {
                _MaLoaiSP = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _MoTa;
            }

            set
            {
                _MoTa = value;
            }
        }

        public string Style
        {
            get
            {
                return _Style;
            }

            set
            {
                _Style = value;
            }
        }

        public string TenLoaiSP
        {
            get
            {
                return _TenLoaiSP;
            }

            set
            {
                _TenLoaiSP = value;
            }
        }
        public eLoaiSanPham()
        {
            this._MaLoaiSP = "";
            this._TenLoaiSP = "";
            this._MoTa = "";
            this._Style="";
        }
        public eLoaiSanPham(string MaLoai,string TenLoai,string MoTa,string Style)
        {
            this._MaLoaiSP = MaLoai;
            this._TenLoaiSP = TenLoai;
            this._MoTa = MoTa;
            this._Style = Style;
        }

        public override bool Equals(object obj)
        {
            return this._MaLoaiSP.ToLower().Equals(((eLoaiSanPham)obj).MaLoaiSP.ToLower());
        }

        public override int GetHashCode()
        {
            return this._MaLoaiSP.ToLower().GetHashCode();
        }
    }
}
