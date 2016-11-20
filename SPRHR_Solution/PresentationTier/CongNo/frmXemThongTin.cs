using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.CongNo;
using BusinessEntities.PhongKeHoach;
using BusinessLogicTier.CongNo;

namespace PresentationTier.CongNo
{
    public partial class frmXemThongTin : Form
    {
        private CongNo_ALL_BUS CN;
        private ThoiGian TG = null;
        public frmXemThongTin()
        {
            InitializeComponent();
            CN = new CongNo_ALL_BUS();
        }

        private void btnNoNCC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn thời gian cần xem");
            frmNhapThoiGian f = new frmNhapThoiGian();
            f.ShowDialog();
            TG = f.GetThoiGian();
            f.Close();
            if (TG == null)
                return;
            dgvAll.DataSource = CN.GetListNoCuaNhaCungCap(TG.NgayBatDau, TG.NgayKetThuc);
            if (dgvAll.DataSource == null)
            {
                DialogResult dlr = MessageBox.Show("Không có công nợ trong thời gian này, chọn khoản thời gian khác ??", "", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    btnNoNCC_Click(btnNoNCC, new EventArgs());
                }
            }
            TG = null;

        }

        private void btnNoKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn thời gian cần xem");
            frmNhapThoiGian f = new frmNhapThoiGian();
            f.ShowDialog();
            TG = f.GetThoiGian();
            f.Close();
            if (TG == null)
                return;
            dgvAll.DataSource = CN.GetListNoCuaKhachHang(TG.NgayBatDau, TG.NgayKetThuc);
            if (dgvAll.DataSource == null)
            {
                DialogResult dlr = MessageBox.Show("Không có công nợ trong thời gian này, chọn khoản thời gian khác ??", "", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    btnNoNCC_Click(btnNoNCC, new EventArgs());
                }
            }
            TG = null;
        }

        private void btnNoQuaHan_Click(object sender, EventArgs e)
        {
            dgvAll.DataSource = CN.GetListNoQuaHan();
            if (dgvAll.DataSource == null)
            {
                MessageBox.Show("Không có nợ quá hạn");
                return;
            }
        }

        private void btnNoDaTra_Click(object sender, EventArgs e)
        {
            dgvAll.DataSource = CN.GetListNoDaTra();
            if (dgvAll.DataSource == null)
            {
                MessageBox.Show("Không có nợ đã trả");
                return;
            }
        }

        private void btnNoToiHan_Click(object sender, EventArgs e)
        {
            dgvAll.DataSource = CN.GetListNoToiHan();
            if (dgvAll.DataSource == null)
            {
                MessageBox.Show("Không có nợ tới hạn");
                return;
            }
        }
    }
    public class ThoiGian
    {
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public ThoiGian(DateTime pNgayBatDau, DateTime pNgayKetThuc)
        {
            NgayBatDau = pNgayBatDau;
            NgayKetThuc = pNgayKetThuc;
        }
        public ThoiGian()
        {

        }
    }
}
