using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace SPRHR_CommunicationManagement
{
    public class ConvertXML<T>
    {
        /// <summary>
        /// Convert đối tượng sang XML để gửi đi
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string ConvertObjectToXML(T p)
        {
            string xml = "";
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream())
            {
                ser.Serialize(ms, p);
                ms.Position = 0;
                xml = new StreamReader(ms).ReadToEnd();
            }
            return xml;
        }
    }
}
