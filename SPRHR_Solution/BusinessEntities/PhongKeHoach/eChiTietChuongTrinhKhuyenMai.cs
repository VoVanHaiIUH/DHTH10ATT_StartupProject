using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eChiTietChuongTrinhKhuyenMai
    {
        private string _MaCT, _MaChiTietKhuyenMai, _MaSP;
        private double _MucGiam, _DonGia, _GiaKhuyenMai;

        public double DonGia
        {
            get
            {
                return _DonGia;
            }

            set
            {
                _DonGia = value;
            }
        }

        public double GiaKhuyenMai
        {
            get
            {
                return _GiaKhuyenMai;
            }

            set
            {
                _GiaKhuyenMai = value;
            }
        }

        public string MaChiTietKhuyenMai
        {
            get
            {
                return _MaChiTietKhuyenMai;
            }

            set
            {
                _MaChiTietKhuyenMai = value;
            }
        }

        public string MaCT
        {
            get
            {
                return _MaCT;
            }

            set
            {
                _MaCT = value;
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

        public double MucGiam
        {
            get
            {
                return _MucGiam;
            }

            set
            {
                _MucGiam = value;
            }
        }
        public eChiTietChuongTrinhKhuyenMai()
        {
            this._MaCT = "";
            this._MaChiTietKhuyenMai = "";
            this._MaSP = "";
            this._MucGiam = 0;
            this._DonGia = 0;
            this._GiaKhuyenMai = 0;
        }
        public eChiTietChuongTrinhKhuyenMai(string MaCT, string MaChiTietKhuyenMai, string MaSP, double MucGiam, double DonGia, double GiaKhuyenMai)
        {
            this._MaCT = MaCT;
            this._MaChiTietKhuyenMai = MaChiTietKhuyenMai;
            this._MaSP = MaSP;
            this._MucGiam = MucGiam;
            this._DonGia = DonGia;
            this._GiaKhuyenMai = GiaKhuyenMai;
        }

        public override bool Equals(object obj)
        {
            return this._MaChiTietKhuyenMai.ToLower().Equals(((eChiTietChuongTrinhKhuyenMai)obj)._MaChiTietKhuyenMai.ToLower());
        }

        public override int GetHashCode()
        {
            return this._MaChiTietKhuyenMai.ToLower().GetHashCode();
        }
    }

}