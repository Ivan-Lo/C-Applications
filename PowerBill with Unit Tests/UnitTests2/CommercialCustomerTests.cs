using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPRG200LAB1IVAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialCustomerTests.Tests
{
    [TestClass()]
    public class CommercialCustomerTests
    {
        [TestMethod()]
        public void CalculateCharge_Comprice_Not_Null()
        {
            CommercialCustomer charge = new CommercialCustomer();
            const decimal COM_PRICE = 60.00m;
            const decimal COM_PRICEO = 0.045m;
            Assert.IsNotNull(COM_PRICE);
        }

        [TestMethod()]
        public void CalculateCharge_Compriceo_And_Comprice_NotEqual()
        {
            CommercialCustomer charge = new CommercialCustomer();
            const decimal COM_PRICE = 60.00m;
            const decimal COM_PRICEO = 0.045m;
            Assert.AreNotEqual(COM_PRICE, COM_PRICEO);
        }

        
    }
}