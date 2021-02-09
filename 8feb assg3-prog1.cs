using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
           // 1. Write a program in C# Sharp to count a total number of duplicate elements in an array
        {
            int[] num = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The total number of duplicate elements in the array is " + count);
        }
    }

}
    
