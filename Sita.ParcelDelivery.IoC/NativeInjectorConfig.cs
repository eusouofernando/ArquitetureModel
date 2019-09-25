using Microsoft.Extensions.DependencyInjection;
using Sita.ParcelDelivery.Data.Repository;
using Sita.ParcelDelivery.Data.UnityOfWork;
using Sita.ParcelDelivery.Domain.Interface.Repository;
using Sita.ParcelDelivery.Domain.Interface.Service;
using Sita.ParcelDelivery.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Service
            services.AddScoped<IParcelService, ParcelService>();
            services.AddScoped<IContainerService, ServiceContainer>();
            

            //Repository
            services.AddScoped<IParcelRepository, ParcelRepository>();
            services.AddScoped<IContainerRepository, ContainerRepository>();

        }
    }
}
