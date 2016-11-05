using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.NhanSu
{
    public class eQuaTrinhDaoTao
    {
        private string _maNhanVien;

        public string MaNhanVien
        {
            get { return _maNhanVien; }
            set { _maNhanVien = value; }
        }
        private string _maChuongTrinhDaoTao;

        public string MaChuongTrinhDaoTao
        {
            get { return _maChuongTrinhDaoTao; }
            set { _maChuongTrinhDaoTao = value; }
        }
        private string _loaiDanhGia;

        public string LoaiDanhGia
        {
            get { return _loaiDanhGia; }
            set { _loaiDanhGia = value; }
        }
        private DateTime _ngayDuocDaotao;

        public DateTime NgayDuocDaotao
        {
            get { return _ngayDuocDaotao; }
            set { _ngayDuocDaotao = value; }
        }
        private DateTime _ngayKetThucDaoTao;

        public DateTime NgayKetThucDaoTao
        {
            get { return _ngayKetThucDaoTao; }
            set { _ngayKetThucDaoTao = value; }
        }
        public eQuaTrinhDaoTao(string manv, string mact, string loai, DateTime ngaybd, DateTime ngaykt)
        {
            this._maNhanVien = manv;
            this._maChuongTrinhDaoTao = mact;
            this._loaiDanhGia = loai;
            this._ngayDuocDaotao = ngaybd;
            this._ngayKetThucDaoTao = ngaykt;
        }
        public override int GetHashCode()
        {
            return HashCodeBuilder.Hash(_maNhanVien, _maChuongTrinhDaoTao, _ngayDuocDaotao);
        }
        public override bool Equals(object obj)
        {
            if (this._maChuongTrinhDaoTao == (((eLichSuLamViec)obj)).MaPhongBan)
                if (this._ngayDuocDaotao == (((eLichSuLamViec)obj)).NgayBatDauLamViec)
                    if (this._maNhanVien == (((eChiTietKyLuat)obj)).MaNhanVien) return true;
                    else return false;
                else return false;
            else return false;

        }
    }
}
