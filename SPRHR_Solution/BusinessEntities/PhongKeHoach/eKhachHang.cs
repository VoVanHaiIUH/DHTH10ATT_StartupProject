using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{

    public class eKhachHang
    {
        private string _MaKH, _DiaChi, _SDTKH, _GioiTinh, _TenKH, _MaSoThue, _TenCongTy, _DiaChiCongTy, _SDTCongTy, _EmailCongTy, _SoTaiKhoanNH, _TenNH, _ChiNhanhNH;

        public string ChiNhanhNH
        {
            get
            {
                return _ChiNhanhNH;
            }

            set
            {
                _ChiNhanhNH = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string DiaChiCongTy
        {
            get
            {
                return _DiaChiCongTy;
            }

            set
            {
                _DiaChiCongTy = value;
            }
        }

        public string EmailCongTy
        {
            get
            {
                return _EmailCongTy;
            }

            set
            {
                _EmailCongTy = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }

        public string MaKH
        {
            get
            {
                return _MaKH;
            }

            set
            {
                _MaKH = value;
            }
        }

        public string MaSoThue
        {
            get
            {
                return _MaSoThue;
            }

            set
            {
                _MaSoThue = value;
            }
        }

        public string SDTCongTy
        {
            get
            {
                return _SDTCongTy;
            }

            set
            {
                _SDTCongTy = value;
            }
        }

        public string SDTKH
        {
            get
            {
                return _SDTKH;
            }

            set
            {
                _SDTKH = value;
            }
        }

        public string SoTaiKhoanNH
        {
            get
            {
                return _SoTaiKhoanNH;
            }

            set
            {
                _SoTaiKhoanNH = value;
            }
        }

        public string TenCongTy
        {
            get
            {
                return _TenCongTy;
            }

            set
            {
                _TenCongTy = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }

            set
            {
                _TenKH = value;
            }
        }

        public string TenNH
        {
            get
            {
                return _TenNH;
            }

            set
            {
                _TenNH = value;
            }
        }

        public eKhachHang()
        {
            this._MaKH = "";
            this._TenCongTy = "";
            this._TenNH = "";
            this._ChiNhanhNH = "";
            this._DiaChi = "";
            this._DiaChiCongTy = "";
            this._EmailCongTy = "";
            this._GioiTinh = "";
            this._MaSoThue = "";
            this._SDTCongTy = "";
            this._SDTKH = "";
            this._SoTaiKhoanNH = "";
            this.TenKH = "";
        }
        public eKhachHang(string MaKH,string TenCongTy,string TenNH,string ChiNhanhNH,string DiaChi,string DiaChiCongTy,string EmailCongTy,string GioiTinh,string MaSoThue,string SDTCongTy,string SDTKH,string SoTaiKhoanNH,string TenKH)
        {
            this._MaKH = MaKH;
            this._TenCongTy = TenCongTy;
            this._TenNH = TenNH;
            this._ChiNhanhNH = ChiNhanhNH;
            this._DiaChi = DiaChi;
            this._DiaChiCongTy = DiaChiCongTy;
            this._EmailCongTy = EmailCongTy;
            this._GioiTinh = GioiTinh;
            this._MaSoThue = MaSoThue;
            this._SDTCongTy = SDTCongTy;
            this._SDTKH = SDTKH;
            this._SoTaiKhoanNH = SoTaiKhoanNH;
            this.TenKH = TenKH;
        }
        public override bool Equals(object obj)
        {
            return this._MaKH.ToLower().Equals(((eKhachHang)obj).MaKH.ToLower());
        }
        public override int GetHashCode()
        {
            return this._MaKH.ToLower().GetHashCode();
        }
    }
}
