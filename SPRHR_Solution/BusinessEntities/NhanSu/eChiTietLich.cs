using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eChiTietLich
    {
        private string _maLich;

        public string MaLich
        {
            get { return _maLich; }
            set { _maLich = value; }
        }
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        private DateTime _ngayBatDau;

        public DateTime NgayBatDau
        {
            get { return _ngayBatDau; }
            set { _ngayBatDau = value; }
        }
        private DateTime _ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }
        public override int GetHashCode()
        {
            return HashCodeBuilder.Hash(_maLich, _maNhanVien, _ngayBatDau);
        }
        public override bool Equals(object obj)
        {
            if (this._maLich == (((eChiTietLich)obj)).MaLich)
                if (this._ngayBatDau == (((eChiTietLich)obj)).NgayBatDau)
                    if (this._maNhanVien == (((eChiTietLich)obj)).MaNhanVien) return true;
                    else return false;
                else return false;
            else return false;
        }
        public eChiTietLich(string malich, string manv, string ghichu, DateTime ngaybd, DateTime ngaykt)
        {
            this._maLich = malich;
            this._maNhanVien = manv;
            this._ghiChu = ghichu;
            this._ngayBatDau = ngaybd;
            this._ngayKetThuc = ngaykt;
        }
    }
}
