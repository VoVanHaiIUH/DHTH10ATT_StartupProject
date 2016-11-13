using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Kho
{
    public class eChiTietKho
    {
        private string _masp, _makho;
        private int _soLuong;

        

        public string Makho
        {
            get
            {
                return _makho;
            }

            set
            {
                _makho = value;
            }
        }

        public string Masp
        {
            get
            {
                return _masp;
            }

            set
            {
                _masp = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }
        public eChiTietKho()
        {

        }

        public eChiTietKho(string _masp, string _makho, int _soLuong)
        {
            this._masp = _masp;
            this._makho = _makho;
            this._soLuong = _soLuong;
        }
    }
}
