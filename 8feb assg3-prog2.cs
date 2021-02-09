using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class _8feb_assg3_prog2
    {
        static void Main()
        { 
//        

//            2.WAP to find the eligibility of admission for a professional course based on the following criteria:
//Marks in Maths >= 65
//Marks in Phy >= 55
//Marks in Chem >= 50
//Total in all three subject >= 180
//or
//Total in Math and Phy >= 140


//Test Data :
//Input the marks obtained in Physics :65
//Input the marks obtained in Chemistry :51
//Input the marks obtained in Mathematics :72
//Expected Output :
//The candidate is eligible for admission.
            int maths, phy, chem, total_3, total_math_phy;
            Console.Write("Input the marks obtained in Physics :");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            maths = Convert.ToInt32(Console.ReadLine());
            total_3 = maths + phy + chem;
            total_math_phy = maths + phy;

            if ((maths >= 65) && (phy >= 55) && (chem >= 50))
            {
                if ((total_3 >= 180) || (total_math_phy >= 140))
                    Console.WriteLine("\nThe candidate is eligible for admission.");
            }
            else
                Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
    
