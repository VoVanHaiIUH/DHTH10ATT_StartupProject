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
    public partial class frmSendPhieuDNXK : Form
    {
        private ActiveMQService amqs;
        public frmSendPhieuDNXK()
        {
            InitializeComponent();
            amqs = new ActiveMQService();
        }
        /// <summary>
        /// Gửi phiếu đề nghị xuất kho đến kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            amqs.SendPDNXKToAnotherFalcuty(txtPhieuDNXK.Text, txtMaNV.Text, txtMaKH.Text, dtpNgayLap.Value, txtMaKho.Text);
            MessageBox.Show("Gửi phiếu đề nghị xuất kho thành công", "Thông báo");
        }
        /// <summary>
        /// Tắt Form quản lý gửi phiếu đề nghị xuất kho , trở về form quản lý chính của Phòng Kế Hoạch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSendPhieuDNXK_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Communication frm = new FormMain_Communication();
            frm.Show();
        }
    }
}
