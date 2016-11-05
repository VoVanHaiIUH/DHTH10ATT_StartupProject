using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eChuongTrinhDaoTao
    {
        private string _maChuongTrinhDaoTao;

        public string MaChuongTrinhDaoTao
        {
            get { return _maChuongTrinhDaoTao; }
            set { _maChuongTrinhDaoTao = value; }
        }
        private string _tenChuongTrinhDaoTao;

        public string TenChuongTrinhDaoTao
        {
            get { return _tenChuongTrinhDaoTao; }
            set { _tenChuongTrinhDaoTao = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        private string _coSoDaoTao;

        public string coSoDaoTao
        {
            get { return _coSoDaoTao; }
            set { _coSoDaoTao = value; }
        }
        public eChuongTrinhDaoTao(string maCTDT, string tenCTDT, string ghiChu, string cosoDT)
        {
            this._maChuongTrinhDaoTao = maCTDT;
            this._tenChuongTrinhDaoTao = tenCTDT;
            this._ghiChu = ghiChu;
            this._coSoDaoTao = cosoDT;
        }
        public override int GetHashCode()
        {
            return this._maChuongTrinhDaoTao.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this._maChuongTrinhDaoTao.Equals(((eChuongTrinhDaoTao)obj)._maChuongTrinhDaoTao);
        }
    }
}
