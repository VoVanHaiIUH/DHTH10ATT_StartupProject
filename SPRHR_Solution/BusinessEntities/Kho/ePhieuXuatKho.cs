using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class ePhieuXuatKho
    {
        private string _soPXK, _maNV, _ghiChu, _maKho;
        private DateTime _ngayLap;

        public string SoPXK
        {
            get
            {
                return _soPXK;
            }

            set
            {
                _soPXK = value;
            }
        }

        public string MaNV
        {
            get
            {
                return _maNV;
            }

            set
            {
                _maNV = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return _ghiChu;
            }

            set
            {
                _ghiChu = value;
            }
        }

        public string MaKho
        {
            get
            {
                return _maKho;
            }

            set
            {
                _maKho = value;
            }
        }

        public DateTime NgayLap
        {
            get
            {
                return _ngayLap;
            }

            set
            {
                _ngayLap = value;
            }
        }

        public ePhieuXuatKho(string _soPXK, string _maNV, string _ghiChu, string _maKho, DateTime _ngayLap)
        {
            this.SoPXK = _soPXK;
            this.MaNV = _maNV;
            this.GhiChu = _ghiChu;
            this.MaKho = _maKho;
            this.NgayLap = _ngayLap;
        }

        public ePhieuXuatKho()
        {
        }

        public override bool Equals(object obj)
        {
            ePhieuXuatKho epx = (ePhieuXuatKho)obj;
            return epx.SoPXK.ToLower().Equals(SoPXK.ToLower());
        }
        public override int GetHashCode()
        {
            return this.SoPXK.GetHashCode();
        }
    }
}
