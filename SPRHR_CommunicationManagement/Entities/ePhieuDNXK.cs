using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Serializable]
    public class ePhieuDNXK
    {
        private string _maPhieuDNXK;
        private string _maNhanVien;
        private string _maKH;
        private DateTime _ngayLap;
        private string _maKho;
        private int _tinhTrang;

        public string MaPhieuDNXK
        {
            get
            {
                return _maPhieuDNXK;
            }

            set
            {
                _maPhieuDNXK = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return _maNhanVien;
            }

            set
            {
                _maNhanVien = value;
            }
        }

        public string MaKH
        {
            get
            {
                return _maKH;
            }

            set
            {
                _maKH = value;
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

        public int TinhTrang
        {
            get
            {
                return _tinhTrang;
            }

            set
            {
                _tinhTrang = value;
            }
        }
        public ePhieuDNXK(string pMaPhieuDNXK, string pMaNhanVien, string pMaKH, DateTime pNgayLap, string pMaKho, int pTinhTrang)
        {
            _maPhieuDNXK = pMaPhieuDNXK;
            _maNhanVien = pMaNhanVien;
            _maKH = pMaKH;
            _ngayLap = pNgayLap;
            _maKho = pMaKho;
            _tinhTrang = pTinhTrang;
        }
        public ePhieuDNXK()
        {
            _maKH = "";
            _maKho = "";
            _maNhanVien = "";
            _maPhieuDNXK = "";
            _ngayLap = DateTime.Now;
            _tinhTrang = 0;
        }
    }
}
