using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Tools
{
    public static class XmlTool
    {
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

        public static string XmlUpload(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            string filePath = "";

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    filePath = Path.GetTempFileName();
                    filePaths.Add(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }
            }

            return filePath;
        }
    }
}
