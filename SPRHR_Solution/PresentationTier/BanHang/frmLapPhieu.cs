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

namespace PresentationTier.BanHang
{
    public partial class frmLapPhieu : Form
    {
        BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS db;
        BusinessEntities.BanHang.eHoaDonBanHang hd; 
        Thread t;
        List<BusinessEntities.BanHang.eChiTietHoaDonBanHang> list;
        public frmLapPhieu()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(getTime));
            list = new List<BusinessEntities.BanHang.eChiTietHoaDonBanHang>();
            db = new BusinessLogicTier.BanHang.LapPhieuBanHang.LapPhieuBanHang_BUS();
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            t.Start();
            t.IsBackground = true;
            this.MaximizeBox = false;
            LoadDgV();
        }

        private delegate void Displaytime(DateTime time);

        private void getTime()
        {
            try
            {
                while (true)
                {
                    DateTime temp = DateTime.Now;
                    lblTIme.Invoke(new Displaytime(displaytime), temp);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception)
            {
                t.Abort();
            }

        }

        private void displaytime(DateTime time)
        {
            lblTIme.Text = time.ToLongTimeString() + " " + time.ToLongDateString();
        }

        //Thêm sản phẩm vào giỏ hàng hiện tại
        private void AddList(BusinessEntities.BanHang.eChiTietHoaDonBanHang cthd)
        {
            if (list.Contains(cthd))
            {
                list[list.IndexOf(cthd)].SoLuong += cthd.SoLuong;
            }
            else list.Add(cthd);
        }
        //Bỏ sản phẩm trong giỏ hàng hiện tại
        private void DeleteList(BusinessEntities.BanHang.eChiTietHoaDonBanHang cthd)
        {
            list.Remove(cthd);
        }
        //Load DatagridView
        private void LoadDgV()
        {
            dgvChiTiet.DataSource = null;
            dgvChiTiet.DataSource = list;
            dgvChiTiet.Columns[0].Visible = dgvChiTiet.Columns[1].Visible = false;

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
                    BusinessEntities.BanHang.eGiaBan gia = db.SearchSP(txtMaSP.Text);
                    if (gia == null) throw new Exception("Mã sản phẩm không tồn tại trên bảng giá");
                    if (!Regex.Match(txtSoLuong.Text,"[0-9]{1,5}").Success) throw new Exception("Số lượng phải là một chuỗi số không vượt quá 5 số");
                    if (short.Parse(txtSoLuong.Text) == 0) throw new Exception("Số lượng phải lớn hơn 0");
                    BusinessEntities.BanHang.eChiTietHoaDonBanHang temp = new BusinessEntities.BanHang.eChiTietHoaDonBanHang(txtMaSP.Text, short.Parse(txtSoLuong.Text), gia.GiaBan);
                    if (list.Count > 50) throw new Exception("Số lượng mặt hàng trên 1 hóa đơn không vượt quá 50");
                    list.Add(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                LoadDgV();
                btnThemSP.Tag = 0;
                btnThemSP.Text = "Thêm sản phẩm";
                btnXoaSP.Tag = 0;
                btnXoaSP.Text = "Xóa khỏi giỏ hàng";

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!db.TestNV(txtMaNV.Text)) throw new Exception("Nhân viên này không tồn tại");
                if (!db.TestKH(txtMaKH.Text)) throw new Exception("Khách hàng chưa lập thẻ thành viên");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
