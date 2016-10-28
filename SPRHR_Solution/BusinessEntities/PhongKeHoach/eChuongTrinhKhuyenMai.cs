using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eChuongTrinhKhuyenMai
    {
        private string _MaCT, _TenCT, _MoTa;
        private DateTime _NgayKhoiDong, _NgayKetThuc;

        public string MaCT
        {
            get
            {
                return _MaCT;
            }

            set
            {
                _MaCT = value;
            }
        }

        public string MoTa
        {
            get
            {
                return _MoTa;
            }

            set
            {
                _MoTa = value;
            }
        }

        public DateTime NgayKetThuc
        {
            get
            {
                return _NgayKetThuc;
            }

            set
            {
                _NgayKetThuc = value;
            }
        }

        public DateTime NgayKhoiDong
        {
            get
            {
                return _NgayKhoiDong;
            }

            set
            {
                _NgayKhoiDong = value;
            }
        }

        public string TenCT
        {
            get
            {
                return _TenCT;
            }

            set
            {
                _TenCT = value;
            }
        }

        public eChuongTrinhKhuyenMai()
        {
            this._MaCT = "";
            this.TenCT = "";
            this._NgayKhoiDong = DateTime.Now;
            this._NgayKetThuc = DateTime.Now;
            this._MoTa = "";
        }

        public eChuongTrinhKhuyenMai(string MaCT,string TenCT,DateTime NgayKhoiDong,DateTime NgayKetThuc,string MoTa)
        {
            this._MaCT = MaCT;
            this.TenCT = TenCT;
            this._NgayKhoiDong = NgayKhoiDong;
            this._NgayKetThuc = NgayKetThuc;
            this._MoTa = MoTa;
        }

        public override bool Equals(object obj)
        {
            return this._MaCT.ToLower().Equals(((eChuongTrinhKhuyenMai) obj).MaCT.ToLower());
        }
        public override int GetHashCode()
        {
            return this._MaCT.ToLower().GetHashCode();
        }
    }
}
