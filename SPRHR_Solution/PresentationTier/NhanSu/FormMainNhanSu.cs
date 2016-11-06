using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.NhanSu
{
    public partial class FormMainNhanSu : Form
    {
        public FormMainNhanSu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmXemThongTinNhanVien ttnv = new frmXemThongTinNhanVien();
            ttnv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmXemLichNhanvien xl = new frmXemLichNhanvien();
            xl.Show();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            FormNhanVien nhanvien = new FormNhanVien();
            nhanvien.Show();
        }

        private void btnchucvu_Click(object sender, EventArgs e)
        {
            frmChucVu cv = new frmChucVu();
            cv.Show();
        }

        private void btnphongban_Click(object sender, EventArgs e)
        {
            frmPhongBan pb = new frmPhongBan();
            pb.Show();
        }

        private void btndaotao_Click(object sender, EventArgs e)
        {
            frmChuongTrinhDaoTao dt = new frmChuongTrinhDaoTao();
            dt.Show();
        }

        private void btnkyluat_Click(object sender, EventArgs e)
        {
            frmKyLuat kl = new frmKyLuat();
            kl.Show();
        }

        private void btnLich_Click(object sender, EventArgs e)
        {
            frmLichLamViec lich = new frmLichLamViec();
            lich.Show();
        }
    }
}
