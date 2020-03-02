using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200LAB1IVAN
{
    public static class CustomerDB
    {
        const string path = "customers.txt"; // located in bin/Debug folder

        public static List<Customer> ReadCustomers()
        {
            List<Customer> prodList = new List<Customer>(); // create empty list
            Customer p; // for reading products
            string line; // next line from the file
            string[] fields; // line broken into fields
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate,
                                                 FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)// while there is still unread data
                    {

                        line = sr.ReadLine();
                        fields = line.Split(',');// split where the commas are

                        p = new Customer(); // create customer and fill with data
                        p.AccountNo = Convert.ToInt32(fields[0]);
                        p.CustomerName = fields[1];
                        p.CustomerType = (fields[2]);
                        p.ChargeAmount = Convert.ToDecimal(fields[3]);

                        prodList.Add(p); // add it to the list
                    }
                } // closes sr and recycles
            } // closes fs and recycles
            return prodList;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create,
                                                FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer p in customers)
                    {
                        sw.WriteLine(p.ToCSV());
                        string test = p.ToCSV();
                        Console.WriteLine("test");
                    }
                } // closes the sw and recyles
            }// closes the fs and recycles
        }
    }
}