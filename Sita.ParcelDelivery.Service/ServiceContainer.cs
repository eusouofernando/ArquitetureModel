using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.Interface.Repository;
using Sita.ParcelDelivery.Domain.Interface.Service;
using Sita.ParcelDelivery.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Sita.ParcelDelivery.Service
{
    public class ServiceContainer : IContainerService
    {
        private readonly IContainerRepository _containerRepository;
        private readonly IParcelService _parcelService;

        public ServiceContainer(IContainerRepository containerRepository, IParcelService parcelService)
        {
            _containerRepository = containerRepository;
            _parcelService = parcelService;
        }

        public Container Find(string id)
        {
            return _containerRepository.FindById(id);
        }
        
        public void Save(string fileName)
        {
            Container container = XmlTool.DeserializeObject<Container>(fileName);
            _parcelService.SetDepartment(container.Parcels);            
            _containerRepository.Save(container);
        }
    }
}
