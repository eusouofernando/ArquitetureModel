using Sita.ParcelDelivery.Data.Context;
using Sita.ParcelDelivery.Data.Repository.Base;
using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Data.Repository
{
    public class ParcelRepository : SqlBaseRepository<Parcel>, IParcelRepository
    {
        public ParcelRepository(SqlServerDbCotext sqlServerDbContext) :
            base(sqlServerDbContext)
        { }
    }
}
