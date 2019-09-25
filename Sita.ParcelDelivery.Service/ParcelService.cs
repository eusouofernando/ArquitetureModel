using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.Interface.Service;
using Sita.ParcelDelivery.Domain.OcP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Service
{
    public class ParcelService : IParcelService
    {

        public ParcelService()
        {

        }

        public void SetDepartment(List<Parcel> parcels)
        {
            var departments = new List<DepartmentBase>
            {
                new MailDepartment(),
                new RegularDepartment(),
                new HeavyDepartment()
            };

            foreach (var parcel in parcels)
            {
                foreach (var department in departments)
                {
                    var result = new Department(department).DepartmentValidation(parcel.Weight, parcel.Value);
                    if (!(result is null))
                    {
                        parcel.Department = result;
                        break;
                    }                    
                }
            }
        }
    }
}
