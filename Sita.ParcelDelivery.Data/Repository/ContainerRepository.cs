using Couchbase.Core;
using Couchbase.Extensions.DependencyInjection;
using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.Interface.Repository;
using Sita.ParcelDelivery.Tools;
using System;
using System.Collections.Generic;

namespace Sita.ParcelDelivery.Data.Repository
{
    public class ContainerRepository : IContainerRepository
    {
        private readonly IBucket _bucket;

        public ContainerRepository(IBucketProvider bucketProvider)
        {
            _bucket = bucketProvider.GetBucket("sitadb");
        }
               

        public Container FindById(string id)
        {
            Container container = null;
            var result = _bucket.Get<Container>(id);
            
            if (result.Value is null)
            {
                container = new Container();
            }
            else
            {
                container = result.Value;
                container.Id = id;
            }
            
            return container;
        }

        public void Save(Container container)
        {
            _bucket.Upsert(container.Id, new
            {                
                container.ShippingDate,
                container.Parcels
            });
        }
    }
}
