using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eCuaHang
    {
        private string _MaCuaHang, _TenCuaHang, _DiaChi, _SoDienThoai;

        public string SoDienThoai
        {
            get { return _SoDienThoai; }
            set { _SoDienThoai = value; }
        }

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        public string TenCuaHang
        {
            get { return _TenCuaHang; }
            set { _TenCuaHang = value; }
        }

        public string MaCuaHang
        {
            get { return _MaCuaHang; }
            set { _MaCuaHang = value; }
        }
        private int _TinhTrang;

        public int TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        public eCuaHang()
        {
            this._MaCuaHang = "";
            this._TenCuaHang = "";
            this._TinhTrang = 0;
            this._SoDienThoai = "";
            this._DiaChi = "";

        }
        public eCuaHang(string macuahang,string tencuahang,string diachi,string sodienthoai,int tinhtrang)
        {
            this._MaCuaHang = macuahang;
            this._TenCuaHang = tencuahang;
            this._DiaChi = diachi;
            this._SoDienThoai = sodienthoai;
            this._TinhTrang = tinhtrang;
        }
        public override bool Equals(object obj)
        {
            eCuaHang ch = (eCuaHang)obj;
            return ch._MaCuaHang.ToLower().Equals(ch._MaCuaHang.ToLower());
        }
        public override int GetHashCode()
        {
            return this._MaCuaHang.GetHashCode();
        }
    }
}
