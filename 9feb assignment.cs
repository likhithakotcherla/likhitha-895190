using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Create a class Employee with following attributes 
//  Empid
//  Name
//  dept
//  Manager
//  Basic Salary
//  Exp

//  Depending upon Exp, calculate Net Salary
//if exp > 10 years , DA = 10 % of basic, HRA = 8.5 % of basic , PF = 6200
//if exp > 7 years and less than 10 years , DA = 7 % of basic, HRA = 6.5 % of basic , PF = 4100
//if exp > 5 years and less than 7 years, DA = 4.1 % of basic, HRA = 3.8 % of basic , PF = 1800
//if exp < 10 years , DA = 1.9 % of basic, HRA = 2.0 % of basic , PF = 1200

//Display the details in proper way

// You are supposed to do it for 5  Employees




namespace ConsoleApp8
{
    class Program
    {
        
        int Empid;
        string Name;
        string dept;
        string Manager;
        double BasicSalary;
        int Exp;
        double DA, HRA, PF, NetSalary;
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Emploee ID");
            Empid = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name of the Employee");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Department name");
            dept = Console.ReadLine();
            Console.WriteLine("Enter Manager name");
            Manager = Console.ReadLine();
            Console.WriteLine("Enter BasicSalary");
            BasicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Experience of the employee");
            Exp = Convert.ToByte(Console.ReadLine());

        }
        public void CaluclateNetSalary()
        {
            if (Exp < 10)
            {
                DA = (1.9 * BasicSalary) / 100;
                HRA = (2.0 * BasicSalary) / 100;
                PF = 1200;
            }
            else if (Exp > 5 && Exp < 7)
            {
                DA = (4.1 * BasicSalary) / 100;
                HRA = (3.8 * BasicSalary) / 100;
                PF = 1800;
            }
            else if (Exp > 7 && Exp < 10)
            {
                DA = (7 * BasicSalary) / 100;
                HRA = (6.5 * BasicSalary) / 100;
                PF = 1800;
            }
            else if (Exp > 10)
            {
                DA = (10 * BasicSalary) / 100;
                HRA = (8.5 * BasicSalary) / 100;
                PF = 6200;
            }

            NetSalary = (BasicSalary + DA + HRA) - PF;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID : " + Empid);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary is" + BasicSalary);
            Console.WriteLine("DA is" + DA);
            Console.WriteLine("HRA is" + HRA);
            Console.WriteLine("PF is" + PF);
            Console.WriteLine("Net salary is" + NetSalary);
        }

    }
    class assclasses
    { 
        static void Main()
        {
            Program employee1 = new Program();
            employee1.DisplayEmployeeDetails();
            employee1.CaluclateNetSalary();
            employee1.DisplayEmployeeDetails();

            Program employee2 = new Program();
            employee2.DisplayEmployeeDetails();
            employee2.CaluclateNetSalary();
            employee2.DisplayEmployeeDetails();

            Program employee3 = new Program();
            employee3.DisplayEmployeeDetails();
            employee3.CaluclateNetSalary();
            employee3.DisplayEmployeeDetails();

            Program employee4 = new Program();
            employee4.DisplayEmployeeDetails();
            employee4.CaluclateNetSalary();
            employee4.DisplayEmployeeDetails();

            Program employee5 = new Program();
            employee5.DisplayEmployeeDetails();
            employee5.CaluclateNetSalary();
            employee5.DisplayEmployeeDetails();

        }
    }


}




    

