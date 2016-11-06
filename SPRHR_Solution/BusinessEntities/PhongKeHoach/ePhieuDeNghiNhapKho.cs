using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class ePhieuDeNghiNhapKho
    {
        private string _SoPhieuDeNghiNhapKho, _MaNhanVien, _MoTa, _MaHoaDonNhaCungCap,_MaKho;

        public string MaKho
        {
             get { return _MaKho; }
            set { _MaKho = value; }
        }

        public string MaHoaDonNhaCungCap
        {
            get { return _MaHoaDonNhaCungCap; }
            set { _MaHoaDonNhaCungCap = value; }
        }

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        public string MaNhanVien
        {
            get { return _MaNhanVien; }
            set { _MaNhanVien = value; }
        }

        public string SoPhieuDeNghiNhapKho
        {
            get { return _SoPhieuDeNghiNhapKho; }
            set { _SoPhieuDeNghiNhapKho = value; }
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
        public ePhieuDeNghiNhapKho()
        {
            this.SoPhieuDeNghiNhapKho = "";
            this.MaHoaDonNhaCungCap = "";
            this._MaNhanVien = "";
            this._NgayLap = DateTime.Now;
            this._MaKho = "";
            this._TinhTrang = 0;
            this._MoTa = "";
        }
        public ePhieuDeNghiNhapKho(string MaPhieu,string Manv,string MaHDNCC,string Makho,string Mota,DateTime ngaylap,int tinhtrang)
        {
            this._SoPhieuDeNghiNhapKho = MaPhieu;
            this._MaNhanVien = Manv;
            this._MaHoaDonNhaCungCap = MaHDNCC;
            this._MoTa = Mota;
            this._MaKho = Makho;
            this._NgayLap = ngaylap;
            this._TinhTrang = tinhtrang;
        }
        public override bool Equals(object obj)
        {
                   //object ct = (onbhect)obj;
                //return ct.sohd.tolower().equails.(Sohd.tolower());
            ePhieuDeNghiNhapKho PDNNK = (ePhieuDeNghiNhapKho)obj;
            return PDNNK._SoPhieuDeNghiNhapKho.ToLower().Equals(_SoPhieuDeNghiNhapKho.ToLower());
        }
        public override int GetHashCode()
        {
            return this._SoPhieuDeNghiNhapKho.GetHashCode();
        }
    }
}
