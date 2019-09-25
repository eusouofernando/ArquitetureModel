using Sita.ParcelDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Domain.OcP
{
    public abstract class DepartmentBase
    {

        private const decimal _maxValue = 1000;


        public abstract string Name { get; }

        public abstract Department DepartmentValidation(decimal weight, decimal value);

        public bool NeedInsuranceSign(decimal value)
        {
            bool flag = false;

            if (value > _maxValue)
            {
                flag = true;
            }

            return flag;
        }
    }
}
