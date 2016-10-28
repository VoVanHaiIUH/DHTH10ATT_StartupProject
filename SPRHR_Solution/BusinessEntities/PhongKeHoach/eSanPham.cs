using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eSanPham
    {
        private string _MaSP, _TenSP, _DonViTinh, _KieuDang, _MauSac, _MaLoaiSP, _MoTa;
        private DateTime _NgaySX, _NgayHetHan;
        private double _Trongluong;
        

        public string DonViTinh
        {
            get
            {
                return _DonViTinh;
            }

            set
            {
                _DonViTinh = value;
            }
        }

        public string KieuDang
        {
            get
            {
                return _KieuDang;
            }

            set
            {
                _KieuDang = value;
            }
        }

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

        public string MaSP
        {
            get
            {
                return _MaSP;
            }

            set
            {
                _MaSP = value;
            }
        }

        public string MauSac
        {
            get
            {
                return _MauSac;
            }

            set
            {
                _MauSac = value;
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

        public DateTime NgayHetHan
        {
            get
            {
                return _NgayHetHan;
            }

            set
            {
                _NgayHetHan = value;
            }
        }

        public DateTime NgaySX
        {
            get
            {
                return _NgaySX;
            }

            set
            {
                _NgaySX = value;
            }
        }

        public string TenSP
        {
            get
            {
                return _TenSP;
            }

            set
            {
                _TenSP = value;
            }
        }

        public double Trongluong
        {
            get
            {
                return _Trongluong;
            }

            set
            {
                _Trongluong = value;
            }
        }

        
        public eSanPham()
        {
            this._MaSP = "";
            this._TenSP = "";
            this._Trongluong = 0;
            this._NgaySX = DateTime.Now;
            this._MoTa = "";
            this._DonViTinh = "";
            this._KieuDang = "";
            this._MaLoaiSP = "";
            this._MauSac = "";
            this._NgayHetHan = DateTime.Now;
        }

        public eSanPham(string MaSP, string TenSP, double TrongLuong, DateTime NgaySX, string MoTa, string DonViTinh, string KieuDang, string MaLoai, string MauSac, DateTime NgayHetHan)
        {
            this._MaSP = MaSP;
            this._TenSP = TenSP;
            this._Trongluong = TrongLuong;
            this._NgaySX = NgaySX;
            this._MoTa = MoTa;
            this._DonViTinh = DonViTinh;
            this._KieuDang = KieuDang;
            this._MaLoaiSP = MaSP;
            this._MauSac = MauSac;
            this._NgayHetHan = NgayHetHan;
        }

        public override bool Equals(object obj)
        {
            eSanPham sp = (eSanPham)obj;
            return this._MaSP.ToLower().Equals(sp._MaSP.ToLower());
        }

        public override int GetHashCode()
        {
            return this._MaSP.ToLower().GetHashCode();
        }
    }
}
