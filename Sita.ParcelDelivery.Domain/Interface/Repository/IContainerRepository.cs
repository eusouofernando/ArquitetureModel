using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.Interface.Repository
{
    public interface IContainerRepository
    {
        Container FindById(string id);
        void Save(Container container);
    }
}
