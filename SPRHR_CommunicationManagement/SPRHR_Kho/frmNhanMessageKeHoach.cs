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
namespace SPRHR_Kho
{
    public partial class frmNhanMessageKeHoach : Form
    {
        private ActiveMQService amqs;
        public event MessageActiveMQDeletegate MessageHandler;
        delegate void CallBackMessage(string text);
        public SendText Test;
        public frmNhanMessageKeHoach(SendText send)
        {
            InitializeComponent();
            amqs = new ActiveMQService();
            receiveMSG(); // nghe tất cả
            Test = send;
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
                rtxtMessage.Text += text + "\n";
                string stra = Test("");
            }
        }
        /// <summary>
        /// Gửi message đến các phòng khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSend_Click(object sender, EventArgs e)
        {
            string FacultyName = "Kho: ";
            amqs.SendMessageToPhongKhac(FacultyName + txtGuiThongDiep.Text);
            txtGuiThongDiep.Text = "";
        }
        /// <summary>
        /// Tắt form trao đổi trở về form chính kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhanMessageKeHoach_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Kho frm = new FormMain_Kho();
            frm.Show();
        }
    }
}
