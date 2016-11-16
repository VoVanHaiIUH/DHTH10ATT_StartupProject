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

namespace PresentationTier.BanHang
{
    public partial class frmLapPhieu : Form
    {
        Thread t;
        public frmLapPhieu()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(getTime));
        }

        private void frmLapPhieu_Load(object sender, EventArgs e)
        {
            t.Start();
            t.IsBackground = true;
            this.MaximizeBox = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToShortDateString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Tag.ToString()=="0")
            {
                button1.Tag = 1;
                button1.Text = "Lưu vào giỏ hàng";
                button2.Tag = 1;
                button2.Text = "Hủy bỏ thao tác";
            }
            else
            {
                button1.Tag = 0;
                button1.Text = "Thêm sản phẩm";
                button2.Tag = 0;
                button2.Text = "Xóa khỏi giỏ hàng";
            }
        }
    }
}
