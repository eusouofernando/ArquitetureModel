using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Domain.Entities
{
    [XmlRoot(ElementName = "Container")]
    public class Container
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "ShippingDate")]
        public string ShippingDate { get; set; }

        [XmlArray("parcels")]
        public List<Parcel> Parcels { get; set; }

        
        
    }
}
