using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPRHR_CommunicationManagement
{
    public partial class FormMain_Communication : Form
    {
        public FormMain_Communication()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Chuyển sang form quản lý gửi phiếu đề nghị nhập kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendPhieuDNNK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSendPhieuDNNK frm = new frmSendPhieuDNNK();
            frm.Show();
        }
        /// <summary>
        /// Chuyển sang form quản lý gửi phiếu đề nghị xuất kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendPhieuDNXK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSendPhieuDNXK frm = new frmSendPhieuDNXK();
            frm.Show();
        }
        /// <summary>
        /// Chuyển sang form giao tiếp với các phòng khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThongBaoChung_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSendThongBaoChung frm = new frmSendThongBaoChung();
            frm.Show();
        }

        /// <summary>
        /// Tắt form quản lý chính của phòng kế hoạch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Communication_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn tắt form quản lý chính Phòng kế hoạch không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
                e.Cancel = true;
        }
    }
}
