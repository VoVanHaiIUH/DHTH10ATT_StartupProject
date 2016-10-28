using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eNhaCungCap
    {
        private string _MaNCC, _TenNCC, _DiaChi;
        private int _Phone;

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string MaNCC
        {
            get
            {
                return _MaNCC;
            }

            set
            {
                _MaNCC = value;
            }
        }

        public int Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public string TenNCC
        {
            get
            {
                return _TenNCC;
            }

            set
            {
                _TenNCC = value;
            }
        }

        public eNhaCungCap()
        {
            this._DiaChi = "";
            this._MaNCC = "";
            this._TenNCC = "";
            this._Phone = 0;
        }

        public eNhaCungCap(string DiaChi,string MaNCC,string TenNCC,int Phone)
        {
            this._DiaChi = DiaChi;
            this._MaNCC = MaNCC;
            this._TenNCC = TenNCC;
            this._Phone = Phone;
        }

        public override bool Equals(object obj)
        {

            return this._MaNCC.ToLower().Equals(((eNhaCungCap)obj).MaNCC.ToLower());
        }
        public override int GetHashCode()
        {
            return this._MaNCC.ToLower().GetHashCode();
        }
    }
}
