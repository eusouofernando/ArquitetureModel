using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.Interface.Service
{
    public interface IParcelService
    {
        void SetDepartment(List<Parcel> parcel);
    }
}
