using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestAmongThree
    {
        public static void Largest()
        {
            Console.WriteLine("enter three numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("num1 is greater");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }
        }
    }
}