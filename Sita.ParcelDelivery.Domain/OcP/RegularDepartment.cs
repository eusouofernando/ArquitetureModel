using System;
using System.Collections.Generic;
using System.Text;
using Sita.ParcelDelivery.Domain.Entities;

namespace Sita.ParcelDelivery.Domain.OcP
{
    public class RegularDepartment : DepartmentBase
    {
        public override string Name { get { return "Regular"; } }

        public override Department DepartmentValidation(decimal weight, decimal value)
        {
            Department department = null;
            if (weight <= 10)
            {
                department = new Department(Name, this.NeedInsuranceSign(value));
            }

            return department;
        }
    }
}
