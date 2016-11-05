using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eChucVu
    {
        private string _maChucVu;

        public string MaChucVu
        {
            get { return _maChucVu; }
            set { _maChucVu = value; }
        }
        private string _tenChucVu;

        public string TenChucVu
        {
            get { return _tenChucVu; }
            set { _tenChucVu = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
        public eChucVu(string macv, string tencv, string mota)
        {
            this._maChucVu = macv;
            this._tenChucVu = tencv;
            this._moTa = mota;
        }
        public override int GetHashCode()
        {
            return this._maChucVu.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._maChucVu.Equals(((eChucVu)obj)._maChucVu);
        }
    }
}
