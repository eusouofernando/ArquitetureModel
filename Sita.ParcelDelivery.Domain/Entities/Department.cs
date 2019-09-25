using Sita.ParcelDelivery.Domain.OcP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.Entities
{
    public class Department
    {
        
        private readonly DepartmentBase _departmentBase;

        public Department(DepartmentBase departmentBase)
        {
            _departmentBase = departmentBase;
        }

        public Department()
        {

        }

        public Department(string name, bool NeedInsuranceSign)
        {
            this.Name = name;
            this.NeedInsuranceSign = NeedInsuranceSign;
        }
        
        public string Name { get;  set; }
        public bool NeedInsuranceSign { get;  set; }


        public Department DepartmentValidation(decimal weight, decimal value)
        {
            return _departmentBase.DepartmentValidation(weight, value);
        }
       
    }
}
