using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPRG200LAB1IVAN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialCustomerTests.Tests
{
    [TestClass()]
    public class IndustrialCustomerPeakTests
    {
        [TestMethod()]
        public void CalculateChargeTest_PEAKNotTheSameAsOffPEAK()
        {
            //arrange
            ResidentialCustomer charge = new ResidentialCustomer();

            const decimal IND_PEAKPRICE = 76.00m;
            const decimal IND_PEAKPRICEO = 0.065m;
            const decimal IND_OFFPEAKPRICE = 40.00m;
            const decimal IND_OFFPEAKPRICEO = 0.028m;
            //assert
            Assert.AreNotSame(IND_OFFPEAKPRICE, IND_PEAKPRICE);
        }
        [TestMethod()]
        public void CalculateChargeTest_PEAKRatioNotEqualToOffPEAKRatio()
        {
            //arrange
            ResidentialCustomer charge = new ResidentialCustomer();

            const decimal IND_PEAKPRICE = 76.00m;
            const decimal IND_PEAKPRICEO = 0.065m;
            const decimal IND_OFFPEAKPRICE = 40.00m;
            const decimal IND_OFFPEAKPRICEO = 0.028m;
            //assert
            Assert.AreNotEqual(IND_PEAKPRICEO, IND_OFFPEAKPRICEO);
        }
    }
}