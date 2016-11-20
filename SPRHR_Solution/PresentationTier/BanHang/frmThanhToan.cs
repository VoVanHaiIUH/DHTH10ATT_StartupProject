using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PresentationTier.BanHang
{
    public partial class frmThanhToan : Form
    {
        BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS db;
        BusinessEntities.BanHang.eThanhToan ettThanhToan;
        decimal dcmTongTien;
        public frmThanhToan(decimal pTongTien)
        {
            InitializeComponent();
            db = new BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS();
            dcmTongTien = pTongTien;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.Match(txtSoTienNhan.Text, "[0-9]{1,50}").Success) throw new Exception("Số lượng phải là một chuỗi số không vượt quá 50 số");
                if (decimal.Parse(txtSoTienNhan.Text) < dcmTongTien) throw new Exception("Số tiền nhận phải lớn hơn tổng tiền");
                txtTienDu.Text = (decimal.Parse(txtSoTienNhan.Text) - dcmTongTien).ToString();
                ettThanhToan = new BusinessEntities.BanHang.eThanhToan(decimal.Parse(txtSoTienNhan.Text), cboPThuc.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            txtTongTien.Text = dcmTongTien.ToString();
            cboPThuc.DataSource = db.LoadPT();
            cboPThuc.DisplayMember = "TenPhuongThuc";
            cboPThuc.ValueMember = "MaPhuongThuc";
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {

        }
    }
}
