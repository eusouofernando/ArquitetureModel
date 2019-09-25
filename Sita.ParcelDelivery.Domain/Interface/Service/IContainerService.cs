using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.Interface.Service
{
    public interface IContainerService
    {
        void Save(string fileName);
        Container Find(string id);

    }
}
