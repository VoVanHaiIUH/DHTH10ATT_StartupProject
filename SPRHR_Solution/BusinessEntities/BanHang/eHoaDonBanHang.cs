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
            set { _tongTien = value; }
        }

        private System.DateTime _ngayLap;

        public System.DateTime NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = DateTime.Now; }
        }

        private bool _VAT;

        public bool VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        List<eChiTietHoaDonBanHang> list;

        public eHoaDonBanHang(string mahdgannhat,string makh,string manv,bool VAT)
        {
            this._soHD = NgayLap.ToShortDateString() + "_" + (int.Parse(mahdgannhat) + 1).ToString();
            this._maKH = makh;
            this._maNV = manv;
            this._VAT = VAT;
            list = new List<eChiTietHoaDonBanHang>();
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

            if (obj == null || this._soHD.ToLower() != ((eHoaDonBanHang)obj).SoHD.ToLower())
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
            return this._soHD.GetHashCode();
        }
        public bool AddList(eChiTietHoaDonBanHang cthd)
        {
            if (list.Contains(cthd)) return false;
            eChiTietHoaDonBanHang temp = new eChiTietHoaDonBanHang(cthd.MaSP, cthd.SoLuong, cthd.Gia, cthd.GiaKhuyenMai);
            temp.SoHD = this._soHD;
            temp.SoCTHD = list.Count + 1;
            list.Add(temp);
            return true;
        }

        public void DeleteList(int index)
        {
            list.RemoveAt(index);
        }
        public int Count()
        {
            return list.Count;
        }
    }
}
