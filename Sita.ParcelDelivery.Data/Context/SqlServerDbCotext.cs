using Microsoft.EntityFrameworkCore;
using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Data.Context
{
    public class SqlServerDbCotext : DbContext
    {

        public virtual DbSet<Parcel> Parcel { get; set; }

        public SqlServerDbCotext(DbContextOptions<SqlServerDbCotext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
