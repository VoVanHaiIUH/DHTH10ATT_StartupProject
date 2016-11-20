using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRHR_CommunicationManagement
{
    [Serializable]
    public class ePhieuDNNK
    {
        private string _maPhieuDNNK;
        private DateTime _ngayLap;
        private string _maNhanVien;
        private string _moTa;
        private string _maKho;
        private int _tinhTrang;

        public string MaPhieuDNNK
        {
            get
            {
                return _maPhieuDNNK;
            }

            set
            {
                _maPhieuDNNK = value;
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

        public string MoTa
        {
            get
            {
                return _moTa;
            }

            set
            {
                _moTa = value;
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
        public ePhieuDNNK()
        {
            _maKho = "";
            _maNhanVien = "";
            _maPhieuDNNK = "";
            _moTa = "";
            _ngayLap = DateTime.Now;
            _tinhTrang = 0;
        }
        public ePhieuDNNK(string pMaKho, string pMaNhanVien, string pMaPhieuDNNK, string pMoTa, DateTime pNgayLap, int pTinhTrang)
        {
            _maKho = pMaKho;
            _maNhanVien = pMaNhanVien;
            _maPhieuDNNK = pMaPhieuDNNK;
            _moTa = pMoTa;
            _ngayLap = pNgayLap;
            _tinhTrang = pTinhTrang;
        }
    }
}
