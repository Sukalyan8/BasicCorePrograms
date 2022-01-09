using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOrOdd
    {
            public static void CheckEvenOddNumber()
            {
                Console.WriteLine("enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("number is even");
                }
                else
                {
                    Console.WriteLine("number is odd");
                }
            }
        
    }

 }


