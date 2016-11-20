using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BanHang
{
    public class eHoaDonBanHang
    {
        private string _soHD;

        public string SoHD
        {
            get { return _soHD; }
        }

        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private decimal _tongTien;

        public decimal TongTien
        {
            get { return _tongTien; }
        }

        private System.DateTime _ngayLap;

        public System.DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }

        private bool _VAT;

        public bool VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }
       
        public eHoaDonBanHang(string pMaKh,string pMaNv,bool pVAT,DateTime pNgayLap,decimal pTongTien)
        {
            this._tongTien = pTongTien;
            this._ngayLap = pNgayLap;
            this._maKH = pMaKh;
            this._maNV = pMaNv;
            this._VAT = pVAT;
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || this._soHD.ToLower() != ((eHoaDonBanHang)obj).SoHD.ToLower() || !(obj is eHoaDonBanHang))
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return GetHashCode();
        }
    }
}
