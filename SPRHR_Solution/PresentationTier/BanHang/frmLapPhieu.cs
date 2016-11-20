using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PresentationTier.BanHang
{
    public delegate void LapPhieu(BusinessEntities.BanHang.eThanhToan pThanhToan);
    public partial class frmLapPhieu : Form
    {
        BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS db;
        BusinessEntities.BanHang.eHoaDonBanHang ehdHD; 
        Thread tT;
        public frmLapPhieu()
        {
            InitializeComponent();
            tT = new Thread(new ThreadStart(GetTime));
            db = new BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS();
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            tT.Start();
            tT.IsBackground = true;
            this.MaximizeBox = false;
            LoadDgV();
        }

        private delegate void Displaytime(DateTime pTime);

        private void GetTime()
        {
            try
            {
                while (true)
                {
                    DateTime dtTemp = DateTime.Now;
                    lblTIme.Invoke(new Displaytime(displaytime), dtTemp);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {
                tT.Abort();
            }

        }

        private void displaytime(DateTime pTime)
        {
            lblTIme.Text = pTime.ToLongTimeString() + " " + pTime.ToLongDateString();
        }

        //private bool LapPhieu(BusinessEntities.BanHang.eThanhToan pThanhToan)
        //{

        //}

        /// <summary>
        /// Hiển thị dữ liệu lên DatagrideView
        /// </summary>
        private void LoadDgV()
        {
            try
            {
                dgvChiTiet.DataSource = null;
                dgvChiTiet.DataSource = db.GioHang().ToList();
                dgvChiTiet.Columns[0].HeaderText = "Mã sản phẩm";
                dgvChiTiet.Columns[1].HeaderText = "Tên sản phẩm";
                dgvChiTiet.Columns[2].HeaderText = "Số lượng";
                dgvChiTiet.Columns[3].HeaderText = "Giá";
                dgvChiTiet.Columns[4].HeaderText = "Khuyến mãi";
            }
            catch (Exception)
            {
                return;
            }
        }
      
        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvChiTiet.DataSource != null)
                {
                    int iTemp = dgvChiTiet.CurrentCell.RowIndex;
                    txtMaSP.Text = dgvChiTiet.Rows[iTemp].Cells[0].Value.ToString();
                    txtDonGia.Text = dgvChiTiet.Rows[iTemp].Cells[3].Value.ToString();
                    txtSoLuong.Text = dgvChiTiet.Rows[iTemp].Cells[2].Value.ToString();
                    txtKM.Text = dgvChiTiet.Rows[iTemp].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dgvChiTiet_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTiet.DataSource != null)
                {
                    int iTemp = dgvChiTiet.CurrentCell.RowIndex;
                    txtMaSP.Text = dgvChiTiet.Rows[iTemp].Cells[0].Value.ToString();
                    txtDonGia.Text = dgvChiTiet.Rows[iTemp].Cells[3].Value.ToString();
                    txtSoLuong.Text = dgvChiTiet.Rows[iTemp].Cells[2].Value.ToString();
                    txtKM.Text = dgvChiTiet.Rows[iTemp].Cells[4].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void radYVAT_CheckedChanged(object sender, EventArgs e)
        {
            if(radYVAT.Checked==true)
            {
                txtTongTien.Text = ((db.TongTien() * 10 / 100) + db.TongTien()).ToString(); 
            }
            else
            {
                txtTongTien.Text = db.TongTien().ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!db.TestNV(txtMaNV.Text)) throw new Exception("Nhân viên này không tồn tại");
                if (!db.TestKH(txtMaKH.Text)) throw new Exception("Khách hàng chưa lập thẻ thành viên");
                if (db.GioHang().Count < 1) throw new Exception("Phải có ít nhất 1 món hàng");
                if (radNVAT.Checked == false && radYVAT.Checked == false) throw new Exception("Vui lòng chọn 1 hình thức in phiếu VAT");
                ehdHD = new BusinessEntities.BanHang.eHoaDonBanHang(txtMaKH.Text, txtMaNV.Text, radYVAT.Checked, DateTime.Now, decimal.Parse(txtTongTien.Text));
                frmThanhToan frmThanhToan = new frmThanhToan(decimal.Parse(txtTongTien.Text));
                frmThanhToan.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (btnXoaSP.Tag.ToString() == "0")
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm khỏi giỏ hàng hay không ?", "Truy vấn ý kiến", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.No)
                {
                    return;
                }
                db.DeleteList(dgvChiTiet.CurrentRow.Cells[0].Value.ToString());
                LoadDgV();
                if (radYVAT.Checked == true)
                {
                    txtTongTien.Text = ((db.TongTien() * 10 / 100) + db.TongTien()).ToString();
                }
                else
                    txtTongTien.Text = db.TongTien().ToString();
            }
            else
            {
                txtMaSP.ReadOnly = txtSoLuong.ReadOnly = true;
                txtMaSP.Text = txtSoLuong.Text = "";
                btnThemSP.Tag = 0;
                btnThemSP.Text = "Thêm sản phẩm";
                btnXoaSP.Tag = 0;
                btnXoaSP.Text = "Xóa khỏi giỏ hàng";
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (btnThemSP.Tag.ToString() == "0")
            {
                btnThemSP.Tag = 1;
                btnThemSP.Text = "Lưu vào giỏ hàng";
                btnXoaSP.Tag = 1;
                btnXoaSP.Text = "Hủy bỏ thao tác";
                txtDonGia.Text = txtKM.Text = txtMaSP.Text = txtSoLuong.Text = "";
                txtMaSP.ReadOnly = txtSoLuong.ReadOnly = false;
            }
            else
            {
                try
                {
                    if (!Regex.Match(txtSoLuong.Text, "[0-9]{1,5}").Success) throw new Exception("Số lượng phải là một chuỗi số không vượt quá 5 số");
                    if (short.Parse(txtSoLuong.Text) == 0) throw new Exception("Số lượng phải lớn hơn 0");
                    object oGia = db.SearchSP(txtMaSP.Text, short.Parse(txtSoLuong.Text), db.GetCTKM(txtMaSP.Text));
                    if (oGia == null) throw new Exception("Mã sản phẩm không tồn tại trên bảng giá");
                    if (db.GioHang().Count > 50) throw new Exception("Số lượng mặt hàng trên 1 hóa đơn không vượt quá 50");
                    db.AddList(oGia);
                    LoadDgV();
                    if (radYVAT.Checked == true)
                    {
                        txtTongTien.Text = ((db.TongTien() * 10 / 100) + db.TongTien()).ToString();
                    }
                    else
                        txtTongTien.Text = db.TongTien().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                btnThemSP.Tag = 0;
                btnThemSP.Text = "Thêm sản phẩm";
                btnXoaSP.Tag = 0;
                btnXoaSP.Text = "Xóa khỏi giỏ hàng";
                txtMaSP.ReadOnly = txtSoLuong.ReadOnly = true;
            }
        }
    }
}
