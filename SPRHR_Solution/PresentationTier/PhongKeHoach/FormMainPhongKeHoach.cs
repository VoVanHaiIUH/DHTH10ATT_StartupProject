using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.PhongKeHoach
{
    public partial class FormMainPhongKeHoach : Form
    {
        public FormMainPhongKeHoach()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            if (CbQl.SelectedItem.ToString() == "Quản Lý Hóa Đơn Nhà Cung Cấp")
            {
                this.Hide();
                FormQuanLyHoaDonNhaCungCap f = new FormQuanLyHoaDonNhaCungCap();
                f.ShowDialog();
                this.Show();

            }
            else if (CbQl.SelectedItem.ToString() == "Quản Lý Sản Phẩm")
            {
                this.Hide();
                FormQuanLySanPham f = new FormQuanLySanPham();
                f.ShowDialog();
                this.Show();
            }
            else if (CbQl.SelectedItem.ToString() == "Quản Lý Khiếu Đề Nghị Nhập Kho")
            {
                this.Hide();
                FormQuanLyKhieuDeNghiNhapKho f = new FormQuanLyKhieuDeNghiNhapKho();
                f.ShowDialog();
                this.Show();
            }
            else if (CbQl.SelectedItem.ToString() == "Quản Lý Hóa Đơn Bán Sĩ")
            {
                this.Hide();
                FormQuanLyHoaDonBanSi f = new FormQuanLyHoaDonBanSi();
                f.ShowDialog();
                this.Show();
            }
            else if (CbQl.SelectedItem.ToString() == "Quản Lý Khiếu Đề Nghị Xuất Kho")
            {
                this.Hide();
                FormQuanLyKhieuDeNghiXuatKho f = new FormQuanLyKhieuDeNghiXuatKho();
                f.ShowDialog();
                this.Show();
            }
            else if (CbQl.SelectedItem.ToString() == "Quản Lý Thẻ Thành Viên")
            {
                this.Hide();
                FormQuanLyTheThanhVien f = new FormQuanLyTheThanhVien();
                f.ShowDialog();
                this.Show();
            }
        }
        private void FormMainPhongKeHoach_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void CbQl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
