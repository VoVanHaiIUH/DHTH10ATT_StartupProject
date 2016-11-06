using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities.PhongKeHoach;
using BusinessLogicTier.PhongKeHoach.PhieuDeNghiNhapKho;

namespace PresentationTier.PhongKeHoach
{
    public partial class ViewPDNNKPrint : Form
    {
        List<ePhieuDeNghiNhapKho> LsP = new List<ePhieuDeNghiNhapKho>();
        List<eChiTietPhieuDeNghiNhapKho> LsC = new List<eChiTietPhieuDeNghiNhapKho>();
        private BindingSource Sr;
        LapPhieuDNNK_BUL NK = new LapPhieuDNNK_BUL();
        public ViewPDNNKPrint()
        {
            InitializeComponent();
        }
        private void LoadPDNNK()
        {
            LsP = NK.LayHetThongTinPDNNK();
            foreach(ePhieuDeNghiNhapKho Phieu in LsP)
            {
                CBPDNNK.Items.Add(Phieu.SoPhieuDeNghiNhapKho);
            }
        }
        private void HienThiThongTinTextBox()
        {
            try
            {
                LsP = NK.LayThongTinPDNNKTheoMa(CBPDNNK.SelectedItem.ToString());
                foreach (ePhieuDeNghiNhapKho phieu in LsP)
                {
                    MaKho.Text = phieu.MaKho;
                    SoHoaDon.Text = phieu.MaHoaDonNhaCungCap;
                    Datetime.Text = phieu.NgayLap.ToString();
                    Nhanvien.Text = NK.LayMaNV(phieu.MaNhanVien);
                }
                LsC = NK.LayHetThongTinChiTietPDNNKTheoMaPhieu(CBPDNNK.SelectedItem.ToString());
                if (LsC.Count() == 0)
                {
                    MessageBox.Show("Null Details");
                }
                else
                {
                    Sr = new BindingSource();
                    Sr.DataSource = LsC;
                    dataGridView1.DataSource = Sr;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewPDNNKPrint_Load(object sender, EventArgs e)
        {
            LoadPDNNK();
            HienThiThongTinTextBox();
        }
        Bitmap bmp;
        private void print_Click(object sender, EventArgs e)
        {
            Graphics G = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics MG = Graphics.FromImage(bmp);
            MG.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

