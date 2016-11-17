using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BanHang
{
    public class eGiaBan
    {
        private string _maSP;

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        private decimal _giaBan;

        public decimal GiaBan
        {
            get { return _giaBan; }
        }

        private System.DateTime _ngayApDung;

        public System.DateTime NgayApDung
        {
            get { return _ngayApDung; }
        }

        public eGiaBan(string masp,decimal giaban,DateTime ngayapdung)
        {
            this._maSP = masp;
            this._giaBan = giaban;
            this._ngayApDung = ngayapdung;
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

            if (obj == null || this._maSP != ((eGiaBan)obj)._maSP || !(obj is eGiaBan))
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
