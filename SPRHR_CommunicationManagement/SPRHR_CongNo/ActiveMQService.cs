using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;
namespace SPRHR_CongNo
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
        ///     Gửi Message tới các phòng khác bằng ActiveMQ
        /// </summary>
        /// <param name="message">Truyền vào Message muốn gửi đi</param>
        public void SendMessageToPhongKhac(string message)
        {
            IDestination _destinationMessage = new ActiveMQTopic("TatCa");
            IMessageProducer producer = SessionMessage.CreateProducer(_destinationMessage);
            IMessage msg = new ActiveMQTextMessage(message);
            producer.Send(msg);
        }
    }
}
