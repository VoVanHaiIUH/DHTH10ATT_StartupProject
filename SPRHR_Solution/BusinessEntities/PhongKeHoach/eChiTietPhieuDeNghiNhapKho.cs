using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
   public class eChiTietPhieuDeNghiNhapKho
    {
        private string _SoPDNNK, _MaSP, _GhiChu;

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

        public string SoPDNNK
        {
            get { return _SoPDNNK; }
            set { _SoPDNNK = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set
            {
                if (value <= 0) throw new Exception("Số Lượng Không Được Bé Hơn 0");
                _SoLuong = value; }
        }
       public eChiTietPhieuDeNghiNhapKho()
        {

        }
       public eChiTietPhieuDeNghiNhapKho(string sophieu,string masp,string ghichu,int soluong)
       {
           this._SoPDNNK = sophieu;
           this._MaSP = masp;
           this._GhiChu = ghichu;
           this._SoLuong = soluong;
       }
       public override bool Equals(object obj)
       {

           eChiTietPhieuDeNghiNhapKho ct = (eChiTietPhieuDeNghiNhapKho)obj;
           return ct._SoPDNNK.ToLower().Equals(ct._SoPDNNK.ToLower());
       }
       public override int GetHashCode()
       {
           return this._SoPDNNK.GetHashCode();
       }
    }
}
