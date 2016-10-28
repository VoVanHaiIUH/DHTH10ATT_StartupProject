using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eChiTietPhieuDeNghiXuatKho
    {
        private string _SoPhieu, _MaSP, _GhiChu;

        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        public string SoPhieu
        {
            get { return _SoPhieu; }
            set { _SoPhieu = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set
            {
                if (value <= 0) throw new Exception("Số Lượng Phải Lớn hơn 0");
                _SoLuong = value; }
        }
        public eChiTietPhieuDeNghiXuatKho()
        {

        }
        public eChiTietPhieuDeNghiXuatKho(string sophieu,string masp,string ghichu,int soluong)
        {
            this._SoPhieu = sophieu;
            this._MaSP = masp;
            this._GhiChu = ghichu;
            this._SoLuong = soluong;
        }
        public override bool Equals(object obj)
        {
            eChiTietPhieuDeNghiXuatKho ct = (eChiTietPhieuDeNghiXuatKho)obj;
            return ct._SoPhieu.ToLower().Equals(ct._SoPhieu.ToLower());
        }
        public override int GetHashCode()
        {
            return this._SoPhieu.GetHashCode();
        }
    }
}
