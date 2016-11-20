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
    public partial class frmReceivePhieuDNXK : Form
    {
        private ActiveMQService amqs;
        public event MessageActiveMQDeletegate MessageHandler;
        delegate void CallBackMessage(string text);
        PhieuDNXKBLL pdnxkBLL;
        private SendText Test;
        public frmReceivePhieuDNXK(SendText send)
        {
            InitializeComponent();
            amqs = new ActiveMQService();
            pdnxkBLL = new PhieuDNXKBLL();
            dgvPhieuDNXK.DataSource = pdnxkBLL.GetAllPhieuDNXK();
            Test = send;
            receiveMSG();
            dgvPhieuDNXK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        /// <summary>
        /// Nhận phiếu đề nghị xuất kho từ phòng kế hoạch gửi xuống
        /// </summary>
        private void receiveMSG()
        {
            ActiveMQQueue destination = new ActiveMQQueue("PhongKeHoachDNXK");
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
        // <summary>
        /// Khi nhận được XML của phiếu đề nghị xuất kho từ phòng kế hoạch ,chuyển nó sang object 
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
                ConvertXML<ePhieuDNXK> a = new ConvertXML<ePhieuDNXK>();
                ePhieuDNXK pdnxkConvert = a.ConvertXMLtoObject(text);
                txtMaKH.Text = pdnxkConvert.MaKH;
                txtMaKho.Text = pdnxkConvert.MaKho;
                txtMaNhanVien.Text = pdnxkConvert.MaNhanVien;
                txtMaPhieuDNXK.Text = pdnxkConvert.MaPhieuDNXK;
                dtpNgayLap.Value = pdnxkConvert.NgayLap;
                string stra = Test("");
                ePhieuDNXK ePDNXK = new ePhieuDNXK() { MaKH = pdnxkConvert.MaKH, MaKho = pdnxkConvert.MaKho, MaNhanVien = pdnxkConvert.MaNhanVien, MaPhieuDNXK = pdnxkConvert.MaPhieuDNXK, NgayLap = pdnxkConvert.NgayLap };
                int kq = pdnxkBLL.InsertPhieuDNXK(ePDNXK);
                if (kq == 1)
                {
                    dgvPhieuDNXK.DataSource = pdnxkBLL.GetAllPhieuDNXK();
                }
                else
                    MessageBox.Show("Mã phiếu đề nghị trùng ! Vui lòng kiểm tra lại", "Thông báo");
            }
        }
        /// <summary>
        /// Duyệt phiếu đề nghị xuất kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(pdnxkBLL.UpdatePhieuDNXK(txtMaPhieuDNXK.Text))
            {
                MessageBox.Show("Phiếu đề nghị đã được duyệt","Thông báo");
                dgvPhieuDNXK.DataSource = pdnxkBLL.GetAllPhieuDNXK();
            }
            else
                MessageBox.Show("Phiếu đề nghị chưa được duyệt", "Thông báo");
        }
        /// <summary>
        /// Xử lý thay đổi textbox theo dòng được chọn trên datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPhieuDNXK_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if(dgvPhieuDNXK.SelectedRows.Count>0)
            {
                txtMaPhieuDNXK.Text = e.Row.Cells["MaPhieuDNXK"].Value.ToString();
                txtMaNhanVien.Text = e.Row.Cells["MaNhanVien"].Value.ToString();
                txtMaKH.Text = e.Row.Cells["MaKH"].Value.ToString();
                dtpNgayLap.Text = e.Row.Cells["NgayLap"].Value.ToString();
                txtMaKho.Text = e.Row.Cells["MaKho"].Value.ToString();
            }
        }
        /// <summary>
        /// Tắt form quản lý phiếu đề nghị xuất kho trở về form chính của kho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmReceivePhieuDNXK_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            FormMain_Kho frm = new FormMain_Kho();
            frm.Show();
        }
    }
}
