using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace SPRHR_Kho
{
    public class ConvertXML<T>
    {
        /// <summary>
        /// Convert file xml nhận được sang đối tượng
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public T ConvertXMLtoObject(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T obj = (T)ser.Deserialize(new StringReader(xml));
            return obj;
        }
    }
}
