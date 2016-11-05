using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eLichSuLamViec
    {
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _maPhongBan;

        public string MaPhongBan
        {
            get { return _maPhongBan; }
            set { _maPhongBan = value; }
        }
        private DateTime _ngayBatDauLamViec;

        public DateTime NgayBatDauLamViec
        {
            get { return _ngayBatDauLamViec; }
            set { _ngayBatDauLamViec = value; }
        }
        private DateTime _ngayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return _ngayKetThuc; }
            set { _ngayKetThuc = value; }
        }
        private string _maChucVu;

        public string MaChucVu
        {
            get { return _maChucVu; }
            set { _maChucVu = value; }
        }
        public eLichSuLamViec (string manv, string maphong, DateTime ngaybd, DateTime ngayketthuc, string machucvu)
        {
            this._maNhanVien=manv;
            this._maPhongBan=maphong;
            this._ngayBatDauLamViec=ngaybd;
            this._ngayKetThuc=ngayketthuc;
            this._maChucVu = machucvu;
        }
        public override int GetHashCode()
        {
            return HashCodeBuilder.Hash(_maNhanVien, _maPhongBan, _ngayBatDauLamViec);
        }
        public override bool Equals(object obj)
        {
            if(this._maPhongBan==(((eLichSuLamViec)obj)).MaPhongBan)
                   if(this._ngayBatDauLamViec==(((eLichSuLamViec)obj)).NgayBatDauLamViec)
                        if(this._maNhanVien==(((eChiTietKyLuat)obj)).MaNhanVien) return true;
            else return false;
            else return false;
            else return false;

        }
    }
}
