﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.PhongKeHoach;
using BusinessLogicTier.PhongKeHoach.SanPham;
using BusinessLogicTier.PhongKeHoach.HoaDonPhiaNhaCungCap;
using BusinessEntities.NhanSu;
namespace PresentationTier.PhongKeHoach
{
    public partial class FormQuanLyHoaDonNhaCungCap : Form
    {
        LapHoaDonNhaCC_BUL Hdncc = new LapHoaDonNhaCC_BUL();
        SanPham_BUL Sp = new SanPham_BUL();
        List<eNhaCungCap> lsncc = new List<eNhaCungCap>();
        List<eNhanVien> lsnv = new List<eNhanVien>();
        List<eHoaDonNhaCungCap> lshdncc = new List<eHoaDonNhaCungCap>();

        public FormQuanLyHoaDonNhaCungCap()
        {
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btThemhoadon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaNcc.ValueMember == null || cbMaNhanVien.ValueMember == null || txtSotiendatra.Text == null)
                {
                    MessageBox.Show("Các Thông Tin Nhập Chưa Hết");
                }
                else
                {
                    eHoaDonNhaCungCap hd = new eHoaDonNhaCungCap();
                    hd.MaNhaCungCap = cbMaNcc.ValueMember;
                    hd.MaNhanVien = cbMaNhanVien.ValueMember;
                    hd.SoTienDaTra = Convert.ToDecimal(txtSotiendatra.Text);
                    Hdncc.ThemHoaDonNcc(hd);
                    LoadcmbMaHoaDOn();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error: "  + ex.Message.ToString());
            }
        }
        private void LoadcmbMaHoaDOn()
        {
            lshdncc = Hdncc.GetAllHoaDonNCC();
            cbMahoaDon.DataSource = lshdncc;
            cbMahoaDon.DisplayMember = "MaHoaDonNCC";
            cbMahoaDon.ValueMember = "MaHoaDonNCC";
        }
        private void LoadCBNCC()
        {
            lsncc = Sp.LayNCC();
            foreach(eNhaCungCap e in lsncc)
            {
                cbMaNcc.Items.Add(e);
                cbMaNcc.DisplayMember = e.TenNCC;
                cbMaNcc.ValueMember = e.MaNCC;
            }
        }
        private void LoadCBNV()
        {
            lsnv = Sp.LayNV();
            foreach (eNhanVien e in lsnv)
            {
                cbMaNcc.Items.Add(e);
                cbMaNcc.DisplayMember = e.HoTenNhanVien;
                cbMaNcc.ValueMember = e.MaNhanVien;
            }
        }
        private void FormQuanLyHoaDonNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadCBNCC();
            LoadCBNV();
            LoadcmbMaHoaDOn();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThemNhaCC_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTenncc.Text == null || txtphone.Text == null || txtdiachi.Text == null)
                {
                    MessageBox.Show("Các Thông Tin Băt Buộc Phải Nhập");
                }
                else
                {
                    eNhaCungCap newncc = new eNhaCungCap();
                    newncc.TenNCC = txtTenncc.Text;
                    newncc.DiaChi = txtdiachi.Text;
                    newncc.Phone =Convert.ToInt32(txtphone.Text);
                    Sp.ThemNcc(newncc);
                    LoadCBNCC();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }
        }

        private void cbMahoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lshdncc = Hdncc.GetHoaDonByMa(cbMahoaDon.ValueMember);
                foreach (eHoaDonNhaCungCap  a in lshdncc)
                {
                    txtmanhanvien.Text = a.MaNhanVien;
                    txtManhacc.Text = a.MaNhaCungCap;
                    txtSotiendatra.Text = a.SoTienDaTra.ToString();
                    txtngaylap.Text = a.NgayLap.ToString();
                    txttongtien.Text = a.TongTien.ToString();
                }

            }
            catch (Exception ex)
            {
                 MessageBox.Show("error: "  + ex.Message.ToString());                
            }
        }
    }
}
