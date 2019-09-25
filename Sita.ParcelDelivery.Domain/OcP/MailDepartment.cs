using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.OcP
{
    public class MailDepartment : DepartmentBase
    {
        public override string Name { get { return "Mail"; } }

        public override Department DepartmentValidation(decimal weight, decimal value)
        {
            Department department = null;
            if (weight <= 1)
            {
                department = new Department(Name, this.NeedInsuranceSign(value));
            }

            return department;
        }
    }
}
