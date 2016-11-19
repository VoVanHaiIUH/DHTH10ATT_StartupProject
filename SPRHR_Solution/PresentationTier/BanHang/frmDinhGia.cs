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
            List<string> select = new List<string>();
            select.Add("Sản phẩm chưa được định giá");
            select.Add("Sản phẩm đã được định giá");
            cboSelect.DataSource = select;
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
            object temp = db.GetSP(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
            if (temp == null)
            {
                MessageBox.Show("Sản Phẩm này đã bị xóa khỏi dữ liệu. Vui lòng tải lại dữ liệu", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (PropertyInfo item in temp.GetType().GetProperties())
            {
                 if(item.Name=="MaSP")
                 {
                     txtMaSP.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "TenSp")
                 {
                     txtTenSP.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "TenLoaiSanPham")
                 {
                     txtLoaiSP.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "MauSac")
                 {
                     if (item.GetValue(temp) == null) txtMauSac.Text = "Không có dữ liệu";
                     else
                         txtMauSac.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "TrongLuong")
                 {
                     if (item.GetValue(temp) == null) txtTrongLuong.Text = "Không có dữ liệu";
                     else
                     txtTrongLuong.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "DonViTinh")
                 {
                     if (item.GetValue(temp) == null) txtDonViTinh.Text = "Không có dữ liệu";
                     else
                         txtDonViTinh.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "NgaySanXuat")
                 {
                     txtNgaySX.Text = item.GetValue(temp).ToString();
                 }
                 if (item.Name == "NgayHetHan")
                 {
                     if (item.GetValue(temp) == null) txtNgayHetHan.Text = "Không có dữ liệu";
                     else
                         txtNgayHetHan.Text = item.GetValue(temp).ToString();
                 }
            }
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            object temp = db.GetSP(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
            if (temp == null)
            {
                MessageBox.Show("Sản Phẩm này đã bị xóa khỏi dữ liệu. Vui lòng tải lại dữ liệu", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (PropertyInfo item in temp.GetType().GetProperties())
            {
                if (item.Name == "MaSP")
                {
                    txtMaSP.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "TenSp")
                {
                    txtTenSP.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "TenLoaiSanPham")
                {
                    txtLoaiSP.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "MauSac")
                {
                    if (item.GetValue(temp) == null) txtMauSac.Text = "Không có dữ liệu";
                    else
                        txtMauSac.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "TrongLuong")
                {
                    if (item.GetValue(temp) == null) txtTrongLuong.Text = "Không có dữ liệu";
                    else
                        txtTrongLuong.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "DonViTinh")
                {
                    if (item.GetValue(temp) == null) txtDonViTinh.Text = "Không có dữ liệu";
                    else
                        txtDonViTinh.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "NgaySanXuat")
                {
                    txtNgaySX.Text = item.GetValue(temp).ToString();
                }
                if (item.Name == "NgayHetHan")
                {
                    if (item.GetValue(temp) == null) txtNgayHetHan.Text = "Không có dữ liệu";
                    else
                        txtNgayHetHan.Text = item.GetValue(temp).ToString();
                }
            }
        }
   
    }
}
