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
    public delegate void MessageActiveMQDeletegate(string message);
    public partial class frmReceivePhieuDNNK : Form
    {
        private ActiveMQService amqs;
        public event MessageActiveMQDeletegate MessageHandler;
        delegate void CallBackMessage(string text);
        PhieuDNNKBLL pdnnkBLL;
        private SendText Test;
        public frmReceivePhieuDNNK(SendText send)
        {
            InitializeComponent();
            amqs = new ActiveMQService();
            pdnnkBLL = new PhieuDNNKBLL();
            dgvPhieuDNNK.DataSource = pdnnkBLL.GetAllPhieuDNNK();
            Test = send;
            receiveMSG();
            dgvPhieuDNNK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        /// Nhận phiếu đề nghị nhập kho từ phòng kế hoạch gửi xuống
        /// </summary>
        private void receiveMSG()
        {
            ActiveMQQueue destination = new ActiveMQQueue("PhongKeHoachDNNK");
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
        /// <summary>
        /// Khi nhận được XML của phiếu đề nghị nhập kho từ phòng kế hoạch ,chuyển nó sang object 
        /// và add vào các textbox trong form đồng thời thêm nó xuống csdl trong tình trạng 
        /// chưa đọc (duyệt)
        /// </summary>
        /// <param name="text"></param>
        private void SetText(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                CallBackMessage d = new CallBackMessage(SetText);
                this.Invoke(d, new object[] { text });

            }
            else
            {
                ConvertXML<ePhieuDNNK> a = new ConvertXML<ePhieuDNNK>();
                ePhieuDNNK pdnnkConvert = a.ConvertXMLtoObject(text);
                txtMaKho.Text = pdnnkConvert.MaKho;
                txtMoTa.Text = pdnnkConvert.MoTa;
                txtMaNhanVien.Text = pdnnkConvert.MaNhanVien;
                txtMaPhieuDNNK.Text = pdnnkConvert.MaPhieuDNNK;
                dtpNgayLap.Value = pdnnkConvert.NgayLap;
                string stra = Test("");
                ePhieuDNNK ePDNNK = new ePhieuDNNK() {MaKho = txtMaKho.Text,MaNhanVien = txtMaNhanVien.Text,MaPhieuDNNK = txtMaPhieuDNNK.Text , MoTa = txtMoTa.Text,NgayLap = dtpNgayLap.Value };
                int kq = pdnnkBLL.InsertPhieuDNNK(ePDNNK);
                if (kq == 1)
                {
                    dgvPhieuDNNK.DataSource = pdnnkBLL.GetAllPhieuDNNK();
                }
                else
                    MessageBox.Show("Mã phiếu đề nghị trùng ! Vui lòng kiểm tra lại", "Thông báo");
            }
        }
        /// <summary>
        /// Duyệt phiếu đề nghị nhập kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (pdnnkBLL.UpdatePhieuDNNK(txtMaPhieuDNNK.Text))
            {
                MessageBox.Show("Phiếu đề nghị đã được duyệt", "Thông báo");
                dgvPhieuDNNK.DataSource = pdnnkBLL.GetAllPhieuDNNK();
            }
            else
                MessageBox.Show("Phiếu đề nghị chưa được duyệt", "Thông báo");
        }
        /// <summary>
        /// Xử lý thay đổi textbox theo dòng được chọn trên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhieuDNNK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvPhieuDNNK.SelectedRows.Count > 0)
            {
                txtMaPhieuDNNK.Text = e.Row.Cells["MaPhieuDNNK"].Value.ToString();
                txtMaNhanVien.Text = e.Row.Cells["MaNhanVien"].Value.ToString();
                txtMoTa.Text = e.Row.Cells["MoTa"].Value.ToString();
                dtpNgayLap.Text = e.Row.Cells["NgayLap"].Value.ToString();
                txtMaKho.Text = e.Row.Cells["MaKho"].Value.ToString();
            }
        }

        /// <summary>
        /// Tắt form quản lý phiếu đề nghị nhập kho trở về form chính của kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReceivePhieuDNNK_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Kho frm = new FormMain_Kho();
            frm.Show();
        }
    }
}
