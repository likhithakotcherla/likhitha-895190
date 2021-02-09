using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        static void Main()
        {

// 3.Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer. The charge are as follow :

//Unit                               Charge / unit
//upto 199                        @1.20
//200 and above but less than 400        @1.50
//400 and above but less than 600        @1.80
//600 and above                        @2.00

//If bill exceeds Rs. 400 then a surcharge of 15 % will be charged and the minimum bill should be of Rs. 100 / -

// Test Data:
//            1001
//James
//800
//Expected Output :
//Customer IDNO :1001
//Customer Name :James
//unit Consumed: 800
//Amount Charges @Rs. 2.00 per unit : 1600.00
//Surchage Amount : 240.00
//Net Amount Paid By the Customer : 1840.00


            string custID, custName;
            double units, charges = 0, surchage = 0, net_amt;
            Console.Write("Customer IDNO :");
            custID = Console.ReadLine();
            Console.Write("Customer Name :");
            custName = Console.ReadLine();
            Console.Write("unit Consumed :");
            units = Convert.ToDouble(Console.ReadLine());

            if (units <= 199)
            {
                charges = units * 1.20;
                Console.WriteLine("\nAmount Charges @Rs. 1.20 per unit : {0:N2}", charges);
            }
            else if (units >= 200 && units <= 400)
            {
                charges = units * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : {0:N2}", charges);
            }
            else if (units >= 400 && units <= 600)
            {
                charges = units * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : {0:N2}", charges);
            }
            else if (units >= 600)
            {
                charges = units * 2.00;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : {0:N2}", charges);
            }

            if (charges > 400)
            {
                surchage = ((15 * charges) / 100);
            }

            Console.WriteLine("Surchage amount : {0:N2}", surchage);

            net_amt = charges + surchage;

            if (net_amt < 100)
                net_amt = 100;
            Console.WriteLine("Net Amount Paid By the Customer : {0:N2}", net_amt);
        }
    }
}

