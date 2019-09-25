﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Domain.Entities
{
    [XmlRoot(ElementName = "Receipient")]
    public class Receipient
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
    }
}
