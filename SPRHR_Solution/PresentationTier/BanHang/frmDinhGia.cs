using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationTier.BanHang
{
    public partial class frmDinhGia : Form
    {
        BusinessLogicTier.BanHang.DinhGia.DinhGia_BUS db;
 
        public frmDinhGia()
        {
            InitializeComponent();
            db = new BusinessLogicTier.BanHang.DinhGia.DinhGia_BUS();
        }

        private void frmDinhGia_Load(object sender, EventArgs e)
        {
            List<string> lSelect = new List<string>();
            lSelect.Add("Sản phẩm chưa được định giá");
            lSelect.Add("Sản phẩm đã được định giá");
            cboSelect.DataSource = lSelect;
        }

        private void LoadGiaBan()
        {
            dgvSanPham.DataSource = db.LoadGiaBan(); 
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Giá bán";
            dgvSanPham.Columns[2].HeaderText = "Ngày áp dụng";
        }

        private void LoadSanPham()
        {
            dgvSanPham.DataSource = db.LoadSanPham();
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Loại sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Tên sản phẩm";
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelect.Text == "Sản phẩm đã được định giá")
            {
                LoadGiaBan();
            }
            else
            {
                LoadSanPham();
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object oTemp = db.GetSP(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
            if (oTemp == null)
            {
                MessageBox.Show("Sản Phẩm này đã bị xóa khỏi dữ liệu. Vui lòng tải lại dữ liệu", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (PropertyInfo item in oTemp.GetType().GetProperties())
            {
                 if(item.Name=="MaSP")
                 {
                     txtMaSP.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "TenSp")
                 {
                     txtTenSP.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "TenLoaiSanPham")
                 {
                     txtLoaiSP.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "MauSac")
                 {
                     if (item.GetValue(oTemp) == null) txtMauSac.Text = "Không có dữ liệu";
                     else
                         txtMauSac.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "TrongLuong")
                 {
                     if (item.GetValue(oTemp) == null) txtTrongLuong.Text = "Không có dữ liệu";
                     else
                     txtTrongLuong.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "DonViTinh")
                 {
                     if (item.GetValue(oTemp) == null) txtDonViTinh.Text = "Không có dữ liệu";
                     else
                         txtDonViTinh.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "NgaySanXuat")
                 {
                     txtNgaySX.Text = item.GetValue(oTemp).ToString();
                 }
                 if (item.Name == "NgayHetHan")
                 {
                     if (item.GetValue(oTemp) == null) txtNgayHetHan.Text = "Không có dữ liệu";
                     else
                         txtNgayHetHan.Text = item.GetValue(oTemp).ToString();
                 }
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            object oTemp = db.GetSP(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
            if (oTemp == null)
            {
                MessageBox.Show("Sản Phẩm này đã bị xóa khỏi dữ liệu. Vui lòng tải lại dữ liệu", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (PropertyInfo item in oTemp.GetType().GetProperties())
            {
                if (item.Name == "MaSP")
                {
                    txtMaSP.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "TenSp")
                {
                    txtTenSP.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "TenLoaiSanPham")
                {
                    txtLoaiSP.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "MauSac")
                {
                    if (item.GetValue(oTemp) == null) txtMauSac.Text = "Không có dữ liệu";
                    else
                        txtMauSac.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "TrongLuong")
                {
                    if (item.GetValue(oTemp) == null) txtTrongLuong.Text = "Không có dữ liệu";
                    else
                        txtTrongLuong.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "DonViTinh")
                {
                    if (item.GetValue(oTemp) == null) txtDonViTinh.Text = "Không có dữ liệu";
                    else
                        txtDonViTinh.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "NgaySanXuat")
                {
                    txtNgaySX.Text = item.GetValue(oTemp).ToString();
                }
                if (item.Name == "NgayHetHan")
                {
                    if (item.GetValue(oTemp) == null) txtNgayHetHan.Text = "Không có dữ liệu";
                    else
                        txtNgayHetHan.Text = item.GetValue(oTemp).ToString();
                }
            }
        }

        private void btnDinhGia_Click(object sender, EventArgs e)
        {
            if(!db.DinhGiaSP(dgvSanPham.CurrentRow.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi giao dịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Định giá sản phẩm thành công", "Giao dịch hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
   
    }
}
