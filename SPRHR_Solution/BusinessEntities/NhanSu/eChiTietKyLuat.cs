using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eChiTietKyLuat
    {
        private string _maKyLuat;

        public string MaKyLuat
        {
            get { return _maKyLuat; }
            set { _maKyLuat = value; }
        }
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private DateTime _ngayLapKyLuat;

        public DateTime NgayLapKyLuat
        {
            get { return _ngayLapKyLuat; }
            set { _ngayLapKyLuat = value; }
        }
        private string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }
        private DateTime _ngayApDungKyLuat;

        public DateTime NgayApDungKyLuat
        {
            get { return _ngayApDungKyLuat; }
            set { _ngayApDungKyLuat = value; }
        }
        private DateTime _ngayKetThucKyLuat;

        public DateTime NgayKetThucKyLuat
        {
            get { return _ngayKetThucKyLuat; }
            set { _ngayKetThucKyLuat = value; }
        }

        private eChiTietKyLuat(string makl, string manv, string lydo, DateTime ngaykl, DateTime ngayapdung, DateTime ngayketthuc)
        {
            this._maKyLuat = makl;
            this._maNhanVien = manv;
            this._lyDo = lydo;
            this._ngayLapKyLuat = ngaykl;
            this._ngayApDungKyLuat = ngayapdung;
            this._ngayKetThucKyLuat = ngayketthuc;
        }
        public override int GetHashCode()
        {
            return HashCodeBuilder.Hash(_maKyLuat, _maNhanVien, _ngayLapKyLuat);
        }
        public override bool Equals(object obj)
        {
            if(this._maKyLuat==(((eChiTietKyLuat)obj)).MaKyLuat)
                   if(this._ngayLapKyLuat==(((eChiTietKyLuat)obj)).NgayLapKyLuat)
                        if(this._maNhanVien==(((eChiTietKyLuat)obj)).MaNhanVien) return true;
            else return false;
            else return false;
            else return false;

        }

    }
    public static class HashCodeBuilder
    {
        public static int Hash(params object[] keys)
        {
            if (object.ReferenceEquals(keys, null))
            {
                return 0;
            }

            int num = 42;

            checked
            {
                for (int i = 0, length = keys.Length; i < length; i++)
                {
                    num += 37;
                    if (object.ReferenceEquals(keys[i], null))
                    { }
                    else if (keys[i].GetType().IsArray)
                    {
                        foreach (var item in (System.Collections.IEnumerable)keys[i])
                        {
                            num += Hash(item);
                        }
                    }
                    else
                    {
                        num += keys[i].GetHashCode();
                    }
                }
            }

            return num;
        }
    }
}
