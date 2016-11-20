using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
namespace SPRHR_CommunicationManagement
{
    public class ActiveMQService
    {
        private IConnection _connectionMessage;
        private ISession _sessionMessage;


        public ActiveMQService()
        {
            IConnectionFactory _factoryMessage = new ConnectionFactory("tcp://localhost:61616");
            ConnectionMessage = _factoryMessage.CreateConnection("admin", "admin");
            ConnectionMessage.Start();
            SessionMessage = ConnectionMessage.CreateSession(AcknowledgementMode.AutoAcknowledge);
        }

        public IConnection ConnectionMessage
        {
            get
            {
                return _connectionMessage;
            }

            set
            {
                _connectionMessage = value;
            }
        }

        public ISession SessionMessage
        {
            get
            {
                return _sessionMessage;
            }

            set
            {
                _sessionMessage = value;
            }
        }
        /// <summary>
        ///     Gửi phiếu đề nghị xuất kho đến kho
        /// </summary>
        /// <param name="pMaKhachHang">Mã khách hàng xuất kho đến</param>
        /// <param name="pMaKho">Mã kho gửi để xuất kho</param>
        /// <param name="pMaNhanVien">Mã nhân viên xuất kho</param>
        /// <param name="pNgayLap">Ngày xuất kho</param>
        /// <param name="pPhieuDeNghiXuatKho">Mã phiếu đề nghị xuất kho</param>
        public void SendPDNXKToAnotherFalcuty(string pPhieuDeNghiXuatKho,string pMaNhanVien,string pMaKhachHang,DateTime pNgayLap,string pMaKho)
        {
            IDestination _destinationMessage = new ActiveMQQueue("PhongKeHoachDNXK");
            IMessageProducer producer = SessionMessage.CreateProducer(_destinationMessage);
            ePhieuDNXK pdnxk = new ePhieuDNXK(pPhieuDeNghiXuatKho,pMaNhanVien,pMaKhachHang,pNgayLap,pMaKho,0);
            ConvertXML<ePhieuDNXK> transform = new ConvertXML<ePhieuDNXK>();
            string message = transform.ConvertObjectToXML(pdnxk);
            IMessage msg = new ActiveMQTextMessage(message);
            producer.Send(msg);
        }
        /// <summary>
        ///  Gửi phiếu đề nghị nhập kho đến kho
        /// </summary>
        /// <param name="pPhieuDeNghiNhapKho">Mã phiếu đề nghị nhập kho</param>
        /// <param name="pMaKho">Mã kho cần nhập hàng</param>
        /// <param name="pMaNhanVien">Mã nhân viên nhập kho</param>
        /// <param name="pMoTa">Mô tả cho phiếu đề nghị nhập kho</param>
        /// <param name="pNgayLap">Ngày nhập kho</param>
        public void SendPDNNKToAnotherFalcuty(string pPhieuDeNghiNhapKho,string pMaKho,string pMaNhanVien,string pMoTa,DateTime pNgayLap)
        {
            IDestination _destinationMessage = new ActiveMQQueue("PhongKeHoachDNNK");
            IMessageProducer producer = SessionMessage.CreateProducer(_destinationMessage);
            ePhieuDNNK pdnnk = new ePhieuDNNK(pMaKho,pMaNhanVien,pPhieuDeNghiNhapKho,pMoTa,pNgayLap,0);
            ConvertXML<ePhieuDNNK> transform = new ConvertXML<ePhieuDNNK>();
            string message = transform.ConvertObjectToXML(pdnnk);
            IMessage msg = new ActiveMQTextMessage(message);
            producer.Send(msg);
        }
        /// <summary>
        ///     Gửi Message tới các phòng khác bằng ActiveMQ
        /// </summary>
        /// <param name="message">Truyền vào Message muốn gửi đi</param>
        public void SendMessageToAnotherFalcuty(string message)
        {
            IDestination _destinationMessage = new ActiveMQTopic("TatCa");
            IMessageProducer producer = SessionMessage.CreateProducer(_destinationMessage);
            IMessage msg = new ActiveMQTextMessage(message);
            producer.Send(msg);
        }
    }
}
