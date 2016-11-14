using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eNhanVien
    {
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _hoTenNhanVien;

        public string HoTenNhanVien
        {
            get { return _hoTenNhanVien; }
            set { _hoTenNhanVien = value; }
        }
        private DateTime _ngayBatDauLamViec;

        public DateTime NgayBatDauLamViec
        {
            get { return _ngayBatDauLamViec; }
            set { _ngayBatDauLamViec = value; }
        }
        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        private string _soTKNganHang;

        public string SoTKNganHang
        {
            get { return _soTKNganHang; }
            set { _soTKNganHang = value; }
        }
        private string _soDT;

        public string SoDT
        {
            get { return _soDT; }
            set { _soDT = value; }
        }
        private string _queQuan;

        public string QueQuan
        {
            get { return _queQuan; }
            set { _queQuan = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _soCMND;

        public string SoCMND
        {
            get { return _soCMND; }
            set { _soCMND = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _gioTinh;

        public string GioTinh
        {
            get { return _gioTinh; }
            set { _gioTinh = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        public eNhanVien(string manv, string hoten, DateTime ngaybatdaulam, string tinhtrang, string sotk, string sodt, string quenquan, string email, string socmnd, string diachi, string giotinh, DateTime ngaysinh)
        {
            this._maNhanVien = manv;
            this._hoTenNhanVien = hoten;
            this.NgayBatDauLamViec = ngaybatdaulam;
            this._tinhTrang = tinhtrang;
            this._soTKNganHang = sotk;
            this._soDT = sodt;
            this._queQuan = quenquan;
            this._email = email;
            this.SoCMND = socmnd;
            this._diaChi = diachi;
            this._gioTinh = giotinh;
            this._ngaySinh = ngaysinh;
        }

        public eNhanVien()
        {
        }

        public override int GetHashCode()
        {
            return this._soCMND.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._soCMND.Equals(((eNhanVien)obj)._soCMND);
        }
    }
}
