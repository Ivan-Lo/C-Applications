using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200LAB1IVAN
{
    public class ResidentialCustomer : Customer
    {
            // private data
            
            const decimal RES_PRICE = 6.00m;
            const decimal RES_PRICEO = 0.052m;

        // public properties
            

            public ResidentialCustomer() { }
            public ResidentialCustomer(string n, string r) // constructor with params
            {
                CustomerName = n;
                CustomerType = r;
                
            }

            // public operations
            public void CalculateCharge(TextBox kwhUsed)
            {

            // Validator for Residential TextBox
            if (Validator.IsDecimal(kwhUsed, "kWh") &&
               Validator.IsNonNegativeDecimal(kwhUsed, "kWh"))
            {
                // get the input data: kWh
                decimal kWh = Convert.ToDecimal(kwhUsed.Text);
                // Math for calculating price
                ChargeAmount = RES_PRICE + (RES_PRICEO * kWh);
            }
            }

        
        
    }// end class
}// end namespace





