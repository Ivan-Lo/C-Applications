using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200LAB1IVAN
{
    public class IndustrialCustomerPeak : Customer
    {
        // private data
        
        private decimal peakchargeAmount;
        private decimal offpeakchargeAmount;
        const decimal IND_PEAKPRICE = 76.00m;
        const decimal IND_PEAKPRICEO = 0.065m;
        const decimal IND_OFFPEAKPRICE = 40.00m;
        const decimal IND_OFFPEAKPRICEO = 0.028m;
        

        // public properties

        public decimal PeakChargeAmount
        {
            get { return peakchargeAmount; }
            set
            {
                // if provided value is negative, make it zero
                peakchargeAmount = (value < 0) ? -value : value;
            }

        }
        public decimal OffPeakChargeAmount
        {
            get { return offpeakchargeAmount; }
            set
            {
                // if provided value is negative, make it zero
                offpeakchargeAmount = (value < 0) ? -value : value;
            }

        }
        public decimal Total_IND
        {
            get { return PeakChargeAmount + OffPeakChargeAmount; }
            set
            {
                // if provided value is negative, make it zero
                Total_IND = (value < 0) ? -value : value;
                
            }

        }

        public IndustrialCustomerPeak() { }
        public IndustrialCustomerPeak(string n, string pi) // constructor with params
        {
            CustomerName = n;
            CustomerType = pi;
        }

        // public operations
        public void CalculateCharge(TextBox txtPeak, TextBox txtOffPeak)
        {

            // Validator for Industrial Peak TextBox
            if (Validator.IsDecimal(txtPeak, "kWh") &&
               Validator.IsNonNegativeDecimal(txtPeak, "kWh"))
            {
                // get the input data: off peak
                decimal peak = Convert.ToDecimal(txtPeak.Text);

                // calculate if peak < 1000 kWh
                if (peak < 1000)
                {
                    PeakChargeAmount = IND_PEAKPRICE;
                    
                }
                else
                {
                    // calulate if peak > 1000 kWh
                    PeakChargeAmount = IND_PEAKPRICE + (IND_PEAKPRICEO * (peak - 1000));
                    
                }
            }

            
            // Validator for Industrial Off Peak TextBox
            if (Validator.IsDecimal(txtOffPeak, "kWh") &&
               Validator.IsNonNegativeDecimal(txtOffPeak, "kWh"))
                {
                    // get the input data: off peak
                    decimal offPeak = Convert.ToDecimal(txtOffPeak.Text);

                    // calculate if peak < 1000 kWh
                    if (offPeak < 1000)
                    {
                        OffPeakChargeAmount = IND_OFFPEAKPRICE;

                    }
                    else
                    {
                        // calculate if peak > 1000 kWh
                        OffPeakChargeAmount = IND_OFFPEAKPRICE + (IND_OFFPEAKPRICEO * (offPeak - 1000));

                    }
               
            }

        }

        public override string ToString() // for display
        {
            return AccountNo + "," + CustomerName + "," + Total_IND.ToString("c");
            
        }
        
    }// end class
}// end namespace
