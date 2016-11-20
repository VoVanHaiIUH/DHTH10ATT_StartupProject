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

namespace SPRHR_CommunicationManagement
{
    public delegate void MessageActiveMQDeletegate(string message);
    public partial class frmSendThongBaoChung : Form
    {
        private ActiveMQService amqs;
        public event MessageActiveMQDeletegate MessageHandler;
        delegate void CallBackMessage(string text);
        public frmSendThongBaoChung()
        {
            InitializeComponent();
            amqs = new ActiveMQService();
            receiveMSG();
        }
        /// <summary>
        ///     Nhận Message trên tất cả phòng
        /// </summary>
        private void receiveMSG()
        {
            ActiveMQTopic destination = new ActiveMQTopic("TatCa");
            var consumer = amqs.SessionMessage.CreateConsumer(destination);
            consumer.Listener += Consumer_Listener;
            this.MessageHandler += new MessageActiveMQDeletegate(Receive_Delegate);
        }
        void Receive_Delegate(string message)
        {
            SetText(message);
        }
        private void Consumer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage tmsg = message as ActiveMQTextMessage;
                if (this.MessageHandler != null)
                {
                    this.MessageHandler(tmsg.Text);
                }
            }
        }
        private void SetText(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                CallBackMessage d = new CallBackMessage(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text + "\n");   
            }
        }
        /// <summary>
        /// Nút Gửi message đến các phòng khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSend_Click(object sender, EventArgs e)
        {
            string FacultyName = "Phòng kế hoạch: ";
            amqs.SendMessageToAnotherFalcuty(FacultyName + txtGuiThongDiep.Text);
            txtGuiThongDiep.Text = "";
        }
        /// <summary>
        /// Tắt Form quản lý giao tiếp , trở về form quản lý chính của Phòng Kế Hoạch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSendThongBaoChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Communication frm = new FormMain_Communication();
            frm.Show();
        }
    }
}
