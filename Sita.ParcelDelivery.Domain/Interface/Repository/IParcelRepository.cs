using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.Interface.Repository.Base;


namespace Sita.ParcelDelivery.Domain.Interface.Repository
{
    public interface IParcelRepository : ISqlBaseRepository<Parcel>
    {

    }
}
