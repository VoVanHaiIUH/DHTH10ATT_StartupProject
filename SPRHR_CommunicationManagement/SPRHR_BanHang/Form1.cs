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
namespace SPRHR_BanHang
{
    public delegate void MessageActiveMQDeletegate(string message);
    public partial class Form1 : Form
    {
        private ActiveMQService amqs;
        public event MessageActiveMQDeletegate MessageHandler;
        delegate void CallBackMessage(string text);
        public Form1()
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
            if (this.rtxtMessage.InvokeRequired)
            {
                CallBackMessage d = new CallBackMessage(SetText);
                this.Invoke(d, new object[] { text });

            }
            else
            {
                // this.richTextBox1.AppendText(text + "\n");
                //   this.richTextBox2.AppendText(text + "\n");
                rtxtMessage.Text += text + "\n";
                PushNotification.Icon = this.Icon;
                PushNotification.BalloonTipIcon = ToolTipIcon.Info;
                PushNotification.BalloonTipText = "Nhận được tin nhắn mới";
                PushNotification.BalloonTipTitle = "Thông báo";
                PushNotification.ShowBalloonTip(12);
            }
        }
        /// <summary>
        ///     Gửi Message tới các phòng khác
        /// </summary>
        private void txtSend_Click(object sender, EventArgs e)
        {
            string FacultyName = "Bán hàng: ";
            amqs.SendMessageToPhongKhac(FacultyName + txtGuiThongDiep.Text);
            txtGuiThongDiep.Text = "";
        }
    }
}
