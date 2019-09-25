using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.System
{
    public class Program
    {
        public static void Main(string[] args)
        {  

            var container = DeserializeObject<Container>(@"C:\Projetos\SITA\sita\Container_68465468.xml");

        }

        public static T DeserializeObject<T>(string objString)
        {
            Object obj = null;
            XmlSerializer xs = new XmlSerializer(typeof(T));
            
            using (StreamReader memoryStream = new StreamReader(objString))
            {
                XmlTextReader xtr = new XmlTextReader(memoryStream);
                obj = xs.Deserialize(xtr);
            }
            return (T)obj;
        }
    }
}
