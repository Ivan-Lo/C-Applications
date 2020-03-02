using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200LAB1IVAN
{
    // The purpose of this application is to demostrate how to calculate the amount
    // of kWh used by different customers types such as residential, commercial and industrial with the flat rates and charging extra if the customer exceeds
    // a certain amount depending on which customer type they are.

    // Created: Dec 11, 2019
    // Author: Ivan Lo

    public partial class frmPower : Form
    {
        // public constants to represent prices and their respective overcharge prices
        const decimal RES_PRICE = 6.00m;
        const decimal RES_PRICEO = 0.052m;
        const decimal COM_PRICE = 60.00m;
        const decimal COM_PRICEO = 0.045m;
        const decimal IND_PEAKPRICE = 76.00m;
        const decimal IND_PEAKPRICEO = 0.065m;
        const decimal IND_OFFPEAKPRICE = 40.00m;
        const decimal IND_OFFPEAKPRICEO = 0.028m;


        decimal kWh; // input: kWh used
        decimal resRate; // residential rate with no over use
        decimal comRate; // commercial rate with no over use
        decimal peak; // input: peak kWh used
        decimal offPeak; // input: offpeak kWh used
        decimal peakRate; // industrial peak rate
        decimal offPeakRate; // industrial off peak rate

        ResidentialCustomer resCust;
        CommercialCustomer comCust;
        IndustrialCustomerPeak indCustPeak;
  

        //list
        List<Customer> customers = new List<Customer>(); //empty list


        public frmPower()
        {
            InitializeComponent();
        }


        //private void resiCal() // Method for calculating Residental kWh usage
        //{
        //    // Validator for Residential TextBox
        //    if (Validator.IsDecimal(txtKwhUsed, "kWh") &&
        //       Validator.IsNonNegativeDecimal(txtKwhUsed, "kWh"))
        //    {
        //        // get the input data: kWh
        //        kWh = Convert.ToDecimal(txtKwhUsed.Text);
        //        // Math for calculating price
        //        resRate = RES_PRICE + (RES_PRICEO * kWh);
        //    }       
        //}

        //private void comCal() // method for calculationg Commercal kWh usage
        //{   
        //    // Validator for Commercial TextBox
        //    if (Validator.IsDecimal(txtKwhUsed, "kWh") &&
        //       Validator.IsNonNegativeDecimal(txtKwhUsed, "kWh"))

        //        // get the input data: kWh
        //        kWh = Convert.ToDecimal(txtKwhUsed.Text);

        //    if (kWh < 1000) // if function to calculate below the 1000 kWh threshold
        //    {
        //        // calculate if kWh < 1000 kWh
        //        comRate = COM_PRICE;
        //        lblCalculatedCharge.Text = comRate.ToString("c");
        //    }
        //    else
        //    {
        //        // calculate if kWh > 1000 kWh
        //        comRate = COM_PRICE + (COM_PRICEO * (kWh - 1000));
        //        lblCalculatedCharge.Text = comRate.ToString("c");
        //    }
        //}

        //private void IndPeakCal() // Method for calculating Industrial Peak kWh usage
        //{
        //    // Validator for Industrial Peak TextBox
        //    if (Validator.IsDecimal(txtPeak, "kWh") &&
        //       Validator.IsNonNegativeDecimal(txtPeak, "kWh"))

        //    // get the input data: off peak
        //        peak = Convert.ToDecimal(txtPeak.Text);

        //    // calculate if peak < 1000 kWh
        //    if (peak < 1000)
        //    {
        //        peakRate = IND_PEAKPRICE;
        //        lblCalculatedCharge.Text = peakRate.ToString("c");
        //    }
        //    else
        //    {
        //        // calulate if peak > 1000 kWh
        //        peakRate = IND_PEAKPRICE + (IND_PEAKPRICEO * (peak - 1000));
        //        lblCalculatedCharge.Text = peakRate.ToString("c");
        //    }

        //}
        //private void IndOffPeakCal() // Method for calculating Industrial Off Peak kWh usage
        //{
        //    // Validator for Industrial Off Peak TextBox
        //    if (Validator.IsDecimal(txtOffPeak, "kWh") &&
        //       Validator.IsNonNegativeDecimal(txtOffPeak, "kWh"))

        //    // get the input data: off peak
        //    offPeak = Convert.ToDecimal(txtOffPeak.Text);

        //    // calculate if peak < 1000 kWh
        //    if (offPeak < 1000)
        //    {
        //        offPeakRate = IND_OFFPEAKPRICE;
        //        lblCalculatedCharge.Text = offPeakRate.ToString("c");
        //    }
        //    else
        //    {
        //        // calculate if peak > 1000 kWh
        //        offPeakRate = IND_OFFPEAKPRICE + (IND_OFFPEAKPRICEO * (offPeak - 1000));
        //        lblCalculatedCharge.Text = offPeakRate.ToString("c");
        //    }

        //}




        private void btnCalculate_Click(object sender, EventArgs e)
        {



            if (radResidential.Checked) // if residential radio button is checked
            {
                resCust = new ResidentialCustomer();
                resCust.CalculateCharge(txtKwhUsed);
                

                // call Residential method
                //resiCal();
                // display results

                //lblCalculatedCharge.Text = resRate.ToString("c");
                lblCalculatedCharge.Text = resCust.ChargeAmount.ToString();
            }
            else if (radCommercial.Checked) // if commercial radio button is checked
            {
                comCust = new CommercialCustomer();
                comCust.CalculateCharge(txtKwhUsed);

                // call Commercial method
                //comCal();

                // display results
                //lblCalculatedCharge.Text = comRate.ToString("c");
                lblCalculatedCharge.Text = comCust.ChargeAmount.ToString();
            }
            else if (radIndustrial.Checked) // if industrial radio button is checked
            {
                indCustPeak = new IndustrialCustomerPeak();
                indCustPeak.CalculateCharge(txtPeak,txtOffPeak);
               

                // call Industrial Peak method
                //IndPeakCal();
                //IndOffPeakCal();

                // display results
                //lblCalculatedCharge.Text = (peakRate + offPeakRate).ToString("c");
                lblCalculatedCharge.Text = indCustPeak.PeakChargeAmount.ToString();
                lblCalculatedCharge.Text = indCustPeak.OffPeakChargeAmount.ToString();
            }
            

        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            // clear Textboxes and the label that display calculated charge
            txtKwhUsed.Text = "";
            lblCalculatedCharge.Text = "";
            txtOffPeak.Text = "";
            txtPeak.Text = "";
            txtAccountNo.Text = "";
            txtCustomerName.Text = "";
            txtCustomerType.Text = "";
            txtKwhUsed.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // closes the application
            this.Close();
        }

        private void radResidential_CheckedChanged(object sender, EventArgs e)
        {
            // hides labels for specific radio button
            lblPeak.Visible = false;
            lblOffPeak.Visible = false;
            txtPeak.Visible = false;
            txtOffPeak.Visible = false;
            lblKwh.Visible = true;
            txtKwhUsed.Visible = true;

        }

        private void radCommercial_CheckedChanged(object sender, EventArgs e)
        {
            // hides labels for specific radio button
            lblPeak.Visible = false;
            lblOffPeak.Visible = false;
            txtPeak.Visible = false;
            txtOffPeak.Visible = false;
            lblKwh.Visible = true;
            txtKwhUsed.Visible = true;
        }

        private void radIndustrial_CheckedChanged(object sender, EventArgs e)
        {
            // hides labels for specific radio button
            lblKwh.Visible = false;
            txtKwhUsed.Visible = false;
            txtPeak.Visible = true;
            txtOffPeak.Visible = true;
            lblPeak.Visible = true;
            lblOffPeak.Visible = true;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            int AccountNo;
            string CustomerName;
            string CustomerType;
          
            
            
            ;
            {
                //get data from textboxes
                AccountNo = Convert.ToInt32(txtAccountNo.Text);
                CustomerName = txtCustomerName.Text;
                CustomerType = txtCustomerType.Text;
                
                

                if (radResidential.Checked)
                {
                    decimal calculatedcharge = Convert.ToDecimal(lblCalculatedCharge.Text);
                    decimal chargeamount = calculatedcharge;
                    lblCalculatedCharge.Text = calculatedcharge.ToString("c");

                    resCust.ChargeAmount = Convert.ToDecimal(chargeamount);
                    resCust.AccountNo = AccountNo;
                    resCust.CustomerName = CustomerName;
                    resCust.CustomerType = CustomerType;
                   // resCust.ChargeAmount = ChargeAmount;

                    lstList.Items.Add(resCust);

                    customers.Add(resCust);
                }
                else if (radCommercial.Checked)
                {
                    decimal calculatedcharge = Convert.ToDecimal(lblCalculatedCharge.Text);
                    decimal chargeamount = calculatedcharge;
                    lblCalculatedCharge.Text = calculatedcharge.ToString("c");

                    
                    comCust.AccountNo = AccountNo;
                    comCust.CustomerName = CustomerName;
                    comCust.CustomerType = CustomerType;
                    comCust.ChargeAmount = Convert.ToDecimal(chargeamount);
                    lstList.Items.Add(comCust);

                    customers.Add(comCust);
                }
                else if (radIndustrial.Checked)
                {
                    //PeakChargeAmount = Convert.ToDecimal(txtPeak.Text);
                    //PeakChargeAmount = Convert.ToDecimal(txtOffPeak.Text);
                    decimal calculatedcharge = Convert.ToDecimal(lblCalculatedCharge.Text);
                    decimal chargeamount = calculatedcharge;
                    


                    
                indCustPeak.AccountNo = AccountNo;
                indCustPeak.CustomerName = CustomerName;
                indCustPeak.CustomerType = CustomerType;
                indCustPeak.ChargeAmount = Convert.ToDecimal(chargeamount);
                
                    lstList.Items.Add(indCustPeak);

                    customers.Add(indCustPeak);
                    lblCalculatedCharge.Text = calculatedcharge.ToString("c");

                }

                
            }


        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayCustomers();

        }

        private void DisplayCustomers()
        {
            lstList.Items.Clear();

            decimal resCharges = 0;
            decimal comCharges = 0;
            decimal indCharges = 0;
            
            foreach (Customer p in customers)
            {
                lstList.Items.Add(p);
                if (p.CustomerType == "R")
                {
                    resCharges += p.ChargeAmount;
                }
                else if (p.CustomerType == "C")
                {
                    comCharges += p.ChargeAmount;
                }
                else if (p.CustomerType == "I")
                {
                    indCharges += p.ChargeAmount;
                }

            }

            lblTotalCustomers.Text = customers.Count.ToString();
            lblResidentialCharge.Text = resCharges.ToString("c");
            lblCommercialCharge.Text = comCharges.ToString("c");
            lblIndustrialCharge.Text = indCharges.ToString("c");
            lblTotalCharge.Text = Convert.ToString(resCharges + comCharges + indCharges);
            
            
        }




        //read customers from file and display
        private void frmPower_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.ReadCustomers();
            DisplayCustomers();
        }
        //saving data before from closes
        

        private void frmPower_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomers(customers);
        }
    }
}
