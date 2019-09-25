using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.OcP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Test
{
    [TestClass]
    public class RegularDepartmentTST
    {
        //Parcels with a weight up to 10 kg are handled by the "Regular" department.
        [TestMethod]
        public void Is_Regular_Department()
        {

            //ARANGE
            decimal weight = 10;
            decimal value = 10;

            //ACT
            var result = new Department(new RegularDepartment()).DepartmentValidation(weight, value);


            //ASSERT
            Assert.AreEqual("Regular", result.Name);
        }

        
        //Parcels with a weight up to 10 kg are handled by the "Regular" department.
        //Parcels with a value of over € 1000,- need to be signed off by the "Insurance" department, before being processed by Mail, Regular or Heavy department.
        [TestMethod]
        public void Is_Regular_Department_And_Need_Insurance_Sign()
        {

            //ARANGE
            decimal weight = 5;
            decimal value = 2000;

            //ACT
            var result = new Department(new RegularDepartment()).DepartmentValidation(weight, value);


            //ASSERT
            Assert.AreEqual(true, result.NeedInsuranceSign);
        }
    }
}
