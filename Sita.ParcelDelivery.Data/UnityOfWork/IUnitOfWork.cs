using Sita.ParcelDelivery.Domain.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Data.UnityOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IParcelRepository ParcelRepository { get; }

        int Complete();
    }

}
