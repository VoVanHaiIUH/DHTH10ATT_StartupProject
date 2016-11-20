using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
using Entities;
using BLL;
namespace SPRHR_Kho
{
    
    public delegate string SendText(string strInput);
    public partial class FormMain_Kho : Form
    {
        private frmReceivePhieuDNXK frmreceivePhieuDNXK;
        private frmReceivePhieuDNNK frmreceivePhieuDNNK;
        private frmNhanMessageKeHoach frmNhanMessage;
        PhieuDNXKBLL pdnxkBLL;
        public FormMain_Kho()
        {
            InitializeComponent();
            pdnxkBLL = new PhieuDNXKBLL();
            frmreceivePhieuDNXK = new frmReceivePhieuDNXK(TaoThongBaoXuatKho);
            frmreceivePhieuDNNK = new frmReceivePhieuDNNK(TaoThongBaoNhapKho);
            frmNhanMessage = new frmNhanMessageKeHoach(TaoThongBaoMoi);
        }
        /// <summary>
        /// Chuyển qua form quản lý nhận phiếu đề nghị xuất kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceivePhieuDNXK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmreceivePhieuDNXK.Show();
        }
        /// <summary>
        /// Tạo push notification khi nhận được phiếu xuất kho
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        private string TaoThongBaoXuatKho(string strInput)
        {
            PushNotification.Icon = this.Icon;
            PushNotification.BalloonTipIcon = ToolTipIcon.Info;
            PushNotification.BalloonTipText = "Nhận được phiếu đề nghị xuất kho từ phòng kế hoạch";
            PushNotification.BalloonTipTitle = "Thông báo";
            PushNotification.ShowBalloonTip(12);
            return "Done";       
        }
        /// <summary>
        /// Tạo push notification khi nhận được tin nhăn từ các phòng
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        private string TaoThongBaoMoi(string strInput)
        {
            PushNotification.Icon = this.Icon;
            PushNotification.BalloonTipIcon = ToolTipIcon.Info;
            PushNotification.BalloonTipText = "Nhận được tin nhắn mới";
            PushNotification.BalloonTipTitle = "Thông báo";
            PushNotification.ShowBalloonTip(12);
            return "Done";
        }
        /// <summary>
        /// Tạo push notification khi nhận được phiếu đề nghị nhập kho
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        private string TaoThongBaoNhapKho(string strInput)
        {
            PushNotification.Icon = this.Icon;
            PushNotification.BalloonTipIcon = ToolTipIcon.Info;
            PushNotification.BalloonTipText = "Nhận được phiếu đề nghị nhập kho từ phòng kế hoạch";
            PushNotification.BalloonTipTitle = "Thông báo";
            PushNotification.ShowBalloonTip(12);
            return "Done";
        }
        /// <summary>
        /// Chuyển qua form quản lý nhận phiếu đề nghị nhập kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceivePhieuDNNK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmreceivePhieuDNNK.Show();
        }
        /// <summary>
        /// Chuyển qua form trao đổi với các phòng khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThongBaoChung_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanMessage.Show();
        }
        /// <summary>
        /// Tắt form quản lý chính của kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Kho_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn tắt form quản lý chính của kho không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
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
