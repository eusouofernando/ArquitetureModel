using System;
using System.Collections.Generic;
using System.Text;
using Sita.ParcelDelivery.Data.Context;
using Sita.ParcelDelivery.Data.Repository;
using Sita.ParcelDelivery.Domain.Interface.Repository;

namespace Sita.ParcelDelivery.Data.UnityOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlServerDbCotext _context;
        public IParcelRepository ParcelRepository { get; private set; }
                

        public UnitOfWork(SqlServerDbCotext context)
        {
            _context = context;
            ParcelRepository = new ParcelRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
