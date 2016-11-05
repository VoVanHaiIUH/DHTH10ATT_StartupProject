using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eLichLamViec
    {
        private string _maLich;

        public string MaLich
        {
            get { return _maLich; }
            set { _maLich = value; }
        }
        private string _caLamViec;

        public string CaLamViec
        {
            get { return _caLamViec; }
            set { _caLamViec = value; }
        }
        private DateTime _gioLam;

        public DateTime GioLam
        {
            get { return _gioLam; }
            set { _gioLam = value; }
        }
        private DateTime _gioKetThuc;

        public DateTime GioKetThuc
        {
            get { return _gioKetThuc; }
            set { _gioKetThuc = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public eLichLamViec(string malich, string calamviec, DateTime giolam, DateTime gioketthuc, string ghichu)
        {
            this._maLich = malich;
            this._caLamViec = calamviec;
            this._gioLam = giolam;
            this._gioKetThuc = gioketthuc;
            this._ghiChu = ghichu;
        }
        public override int GetHashCode()
        {
            return this._maLich.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._maLich.Equals(((eLichLamViec)obj)._maLich);
        }
    }
}
