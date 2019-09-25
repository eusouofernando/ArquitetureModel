using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sita.ParcelDelivery.Domain.Entities;
using Sita.ParcelDelivery.Domain.OcP;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sita.ParcelDelivery.Test
{
    [TestClass]
    public class MailDepartmentTST
    {
        //Parcels with a weight up to 1 kg are handled by the "Mail" departement.
        [TestMethod]
        public void Is_Mail_Department()
        {

            //ARANGE
            decimal weight = 1;
            decimal value = 10;

            //ACT
            var result = new Department(new MailDepartment()).DepartmentValidation(weight, value);


            //ASSERT
            Assert.AreEqual("Mail", result.Name);
        }


        //Parcels with a weight up to 1 kg are handled by the "Mail" departement.
        //Parcels with a value of over € 1000,- need to be signed off by the "Insurance" department, before being processed by Mail, Regular or Heavy department.
        [TestMethod]
        public void Is_Mail_Department_And_Need_Insurance_Sign()
        {

            //ARANGE
            decimal weight = 1;
            decimal value = 2000;

            //ACT
            var result = new Department(new MailDepartment()).DepartmentValidation(weight, value);


            //ASSERT
            Assert.AreEqual(true, result.NeedInsuranceSign);
        }
    }
}
