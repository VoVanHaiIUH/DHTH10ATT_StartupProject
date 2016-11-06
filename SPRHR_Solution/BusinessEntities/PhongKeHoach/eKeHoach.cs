using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eKeHoach
    {
        private string _MaSP, _KeHoach;

        public string KeHoach
        {
            get { return _KeHoach; }
            set { _KeHoach = value; }
        }

        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
        private int _SLHangMua, _SLHangBan;

        public int SLHangBan
        {
            get { return _SLHangBan; }
            set { _SLHangBan = value; }
        }

        public int SLHangMua
        {
            get { return _SLHangMua; }
            set { _SLHangMua = value; }
        }
        public eKeHoach()
        {
            this._MaSP = "";
            this._SLHangMua = 0;
            this._SLHangBan = 0;
            this._KeHoach = ""; 
        }
        public eKeHoach(string MaSP,int SLD,int SLM,string KHoach)
        {
            this._MaSP = MaSP;
            this._SLHangMua = SLM;
            this._SLHangBan = SLHangBan;
            this._KeHoach = KHoach; 
        }
    }
}
