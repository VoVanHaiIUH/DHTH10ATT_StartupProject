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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //    comboBox1.DataSource = 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        #region CusForm
        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoat", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            tabControl1.Select();
            tabControl1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            tabControl1.Select();
            tabControl1.Focus();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthuyenchuyen_Click(object sender, EventArgs e)
        {
            frmThuyenChuyen tc;
            tc= new frmThuyenChuyen();
            tc.Show();
        }

        private void btnthaydoichucvu_Click(object sender, EventArgs e)
        {
            frmThaiDoiChucVu td;
            td = new frmThaiDoiChucVu();
            td.Show();
        }
    }
}
