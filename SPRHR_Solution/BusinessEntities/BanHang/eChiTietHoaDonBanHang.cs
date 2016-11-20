using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BanHang
{
    public class eChiTietHoaDonBanHang
    {
        private string _soHD;

        public string SoHD
        {
            get { return _soHD; }
            set { _soHD = value; }
        }

        private int _soCTHD;

        public int SoCTHD
        {
            get { return _soCTHD; }
            set { _soCTHD = value; }
        }

        private string _maSP;

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        private short _soLuong;

        public short SoLuong
        {
            get { return _soLuong; }
            set 
            {
                if (value <= 0) throw new Exception("Số lượng phải lớn hơn 0");
                _soLuong = value; }
        }

        private decimal _gia;

        public decimal Gia
        {
            get { return _gia; }
            set
            {
                if (value <= 0) throw new Exception("Giá phải lớn hơn 0");
                _gia = value; 
            }
        }

        private decimal _giaKhuyenMai;

        public decimal GiaKhuyenMai
        {
            get { return _giaKhuyenMai; }
            set {
                if (value > this._gia || value < 0) throw new Exception("Giá khuyến mãi không được nhỏ hơn 0 và phải nhỏ hơn giá sản phẩm");
                _giaKhuyenMai = value; }
        }
        public eChiTietHoaDonBanHang(string pMaSp,short pSoLg,decimal pGia)
        {
            this._maSP = pMaSp;
            this._soLuong = pSoLg;
            this._gia = pGia;
        }

        public eChiTietHoaDonBanHang(string pMaSp, short pSoLg, decimal pGia,decimal pKm)
        {
            this._maSP = pMaSp;
            this._soLuong = pSoLg;
            this._gia = pGia;
            this._giaKhuyenMai = pKm;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || this._soHD.ToLower() != ((eChiTietHoaDonBanHang)obj).SoHD.ToLower() || this._maSP != ((eChiTietHoaDonBanHang)obj)._maSP || !(obj is eChiTietHoaDonBanHang))
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return GetHashCode();
        }
    }
}
