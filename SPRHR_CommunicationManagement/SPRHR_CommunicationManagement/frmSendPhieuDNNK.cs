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
    public partial class frmSendPhieuDNNK : Form
    {
        private ActiveMQService amqs;
        public frmSendPhieuDNNK()
        {
            InitializeComponent();
            amqs = new ActiveMQService();
        }
        /// <summary>
        /// Gửi phiếu đề nghị nhập kho đến kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            amqs.SendPDNNKToAnotherFalcuty(txtPhieuDNNK.Text, txtMaKho.Text,txtMaNV.Text, txtMoTa.Text, dtpNgayLap.Value);
            MessageBox.Show("Gửi phiếu đề nghị nhập kho thành công", "Thông báo");
        }
        /// <summary>
        /// Tắt Form quản lý gửi phiếu đề nghị nhập kho , trở về form quản lý chính của Phòng Kế Hoạch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSendPhieuDNNK_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Communication frm = new FormMain_Communication();
            frm.Show();
        }
    }
}
