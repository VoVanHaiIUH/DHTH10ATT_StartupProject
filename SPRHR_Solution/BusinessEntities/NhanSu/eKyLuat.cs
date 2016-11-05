using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eKyLuat
    {
        private string _maKyLuat;

        public string MaKyLuat
        {
            get { return _maKyLuat; }
            set { _maKyLuat = value; }
        }
        private string _dieuKhoanKyLuay;

        public string DieuKhoanKyLuay
        {
            get { return _dieuKhoanKyLuay; }
            set { _dieuKhoanKyLuay = value; }
        }
        private string _hinhThucKyLuat;

        public string HinhThucKyLuat
        {
            get { return _hinhThucKyLuat; }
            set { _hinhThucKyLuat = value; }
        }
        public eKyLuat(string makl, string dieukhoan, string hinhthuckl)
        {
            this._maKyLuat = makl;
            this._dieuKhoanKyLuay = dieukhoan;
            this._hinhThucKyLuat = hinhthuckl;
        }
        public override int GetHashCode()
        {
            return this._maKyLuat.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._maKyLuat.Equals(((eKyLuat)obj)._maKyLuat);
        }
    }
}
