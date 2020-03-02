using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200LAB1IVAN
{
    public class CommercialCustomer : Customer
    {
        // private data
        
        const decimal COM_PRICE = 60.00m;
        const decimal COM_PRICEO = 0.045m;

        // public properties
        

        public CommercialCustomer() { }
        public CommercialCustomer(string n, string c) // constructor with params
        {
            CustomerName = n;
            CustomerType = c;
        }

        // public operations
        public void CalculateCharge(TextBox kwhUsed)
        {

            // Validator for Commercial TextBox
            if (Validator.IsDecimal(kwhUsed, "kWh") &&
               Validator.IsNonNegativeDecimal(kwhUsed, "kWh"))
            {
                // get the input data: kWh
                decimal kWh = Convert.ToDecimal(kwhUsed.Text);

                if (kWh < 1000) // if function to calculate below the 1000 kWh threshold
                {
                    // calculate if kWh < 1000 kWh
                    ChargeAmount = COM_PRICE;

                }
                else
                {
                    // calculate if kWh > 1000 kWh
                    ChargeAmount = COM_PRICE + (COM_PRICEO * (kWh - 1000));

                }
            }
        }
        
       

    }// end class
}// end namespace