using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Domain.Entities
{
    [XmlRoot(ElementName = "Sender")]
    [XmlType(TypeName = "Company")]
    public class Sender
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
    }
}
