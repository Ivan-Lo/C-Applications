using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPRG200LAB1IVAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResidentialCustomerTest.Tests
{
    [TestClass()]
    public class ResidentialCustomerTests
    {
        [TestMethod()]
        public void CalculateCharge_Resprice_Not_Null()
        {
            //arrange
            ResidentialCustomer charge = new ResidentialCustomer();
            
            decimal res_price = 6.00m;
            //assert
            Assert.IsNotNull(res_price);
        }

        [TestMethod()]
        public void CalculateCharge_Respriceo_And_Resprice_NotEqual()
        {
            //arrange
            ResidentialCustomer charge = new ResidentialCustomer();
            
            decimal res_price = 6.00m;
            decimal res_priceo = 0.052m;
            //assert
            Assert.AreNotEqual(res_price, res_priceo);
        }
    }
}