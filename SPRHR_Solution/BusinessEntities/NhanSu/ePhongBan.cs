using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class ePhongBan
    {
        private string _maPhongBan;

        public string MaPhongBan
        {
            get { return _maPhongBan; }
            set { _maPhongBan = value; }
        }
        private string _tenPhongBan;

        public string TenPhongBan
        {
            get { return _tenPhongBan; }
            set { _tenPhongBan = value; }
        }
        private string _khuVuc;

        public string KhuVuc
        {
            get { return _khuVuc; }
            set { _khuVuc = value; }
        }
        public ePhongBan(string maphong, string tenphong, string khuvuc)
        {
            this._maPhongBan = maphong;
            this._tenPhongBan = tenphong;
            this._khuVuc = khuvuc;
        }
        public override int GetHashCode()
        {
            return this._maPhongBan.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._maPhongBan.Equals(((ePhongBan)obj)._maPhongBan);
        }
    }
}
