using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eDanhGia
    {
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private DateTime _ngayDanhGia;

        public DateTime NgayDanhGia
        {
            get { return _ngayDanhGia; }
            set { _ngayDanhGia = value; }
        }
        private string _loaiDanhGia;

        public string LoaiDanhGia
        {
            get { return _loaiDanhGia; }
            set { _loaiDanhGia = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public eDanhGia(string manv, DateTime ngaydg, string loaidg, string ghichu)
        {
            this._maNhanVien = manv;
            this._ngayDanhGia = ngaydg;
            this._loaiDanhGia = loaidg;
            this._ghiChu = ghichu;
        }
        public override int GetHashCode()
        {
            return HashCodeBuilder.Hash(_maNhanVien, _ngayDanhGia);
        }
        public override bool Equals(object obj)
        {
            if (this._maNhanVien == (((eDanhGia)obj)).MaNhanVien)
                if (this._ngayDanhGia == (((eDanhGia)obj)).NgayDanhGia)
                    return true;
            else return false;
            return false;
        }
    }
}
