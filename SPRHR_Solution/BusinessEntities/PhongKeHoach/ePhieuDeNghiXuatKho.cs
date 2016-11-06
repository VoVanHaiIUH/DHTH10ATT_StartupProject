using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class ePhieuDeNghiXuatKho
    {
        private string _SoPhieuDeNghiXuatKho, _MaNhanVien, _MaKH, _MaKho;

        public string MaKho
        {
            get { return _MaKho; }
            set { _MaKho = value; }
        }

        public string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }

        public string SoPhieuDeNghiXuatKho
        {
            get { return _SoPhieuDeNghiXuatKho; }
            set { _SoPhieuDeNghiXuatKho = value; }
        }
        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private int _TinhTrang;

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public ePhieuDeNghiXuatKho()
        {
            this._SoPhieuDeNghiXuatKho = "1";
            this._MaNhanVien = "";
            this._MaKH = "";
            this._MaKho = "";
            this._NgayLap = DateTime.Now;
            this._TinhTrang = 0;
        }
        public ePhieuDeNghiXuatKho(string sophieu,string manhanvien,string makh,string makho,DateTime ngaylap,int tinhtrang)
        {
            this._SoPhieuDeNghiXuatKho = sophieu;
            this._MaNhanVien = manhanvien;
            this._MaKH = makh;
            this._MaKho = makho;
            this._NgayLap = ngaylap;
            this._TinhTrang = tinhtrang;
        }
        public override bool Equals(object obj)
        {
            ePhieuDeNghiXuatKho xk = (ePhieuDeNghiXuatKho)obj;
            return xk._SoPhieuDeNghiXuatKho.ToLower().Equals(xk._SoPhieuDeNghiXuatKho.ToLower());
        }
        public override int GetHashCode()
        {
            return this._SoPhieuDeNghiXuatKho.GetHashCode();
        }
    }
}
