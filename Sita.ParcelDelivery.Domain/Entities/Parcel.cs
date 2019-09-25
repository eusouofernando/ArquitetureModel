using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Domain.Entities
{
    [XmlRoot(ElementName = "Parcel")]
    public class Parcel
    {
        public Parcel()
        {
            
        }


        [XmlElement(ElementName = "Sender")]
        public Sender Sender { get; set; }

        [XmlElement(ElementName = "Receipient")]
        public Receipient Receipient { get; set; }

        [XmlElement(ElementName = "Weight")]
        public decimal Weight { get; set; }

        [XmlElement(ElementName = "Value")]
        public decimal Value { get; set; }

        [XmlIgnore]
        public Department Department { get; set; }
    }
}
