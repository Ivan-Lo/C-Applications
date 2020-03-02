using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200LAB1IVAN
{
    public class Customer
    {
        // private data
        private int accountNo;
        private decimal chargeAmount;
        

        // public properties
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }


        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                // if provided value is negative, make it zero
                accountNo = (value < 0) ? -value : value;
            }

        }
        public decimal ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                // if provided value is negative, make it zero
                chargeAmount = (value < 0) ? -value : value;
            }

        }
        public override string ToString() // for display
        {
            return AccountNo + "," + CustomerName + "," + CustomerType + "," + ChargeAmount.ToString("c");
        }
        public string ToCSV()// for writing CSV file - no formatting
        {
            return AccountNo + "," + CustomerName + "," + CustomerType + "," + ChargeAmount.ToString();
        }

        //public Customer() { }
        //public Customer(string n, string r, decimal c) // constructor with params
        //{
        //    CustomerName = n;
        //    CustomerType = r;
        //    ChargeAmount = c;
        //}

        //// public operations


        //public override string ToString() // for display
        //{
        //    return AccountNo + "," + CustomerName + "," + ChargeAmount.ToString("c");
        //}
        //public string ToCSV()// for writing CSV file - no formatting
        //{
        //    return AccountNo + "," + CustomerName + "," + ChargeAmount.ToString();
        //}
    }// end class
}// end namespace


