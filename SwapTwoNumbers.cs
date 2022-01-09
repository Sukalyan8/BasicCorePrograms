using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapTwoNumbers
    {
        public static void SwapTheNumbers()
        {
            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swapping:{0} {1}", num1, num2);
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping:{0} {1}", num1, num2);
        }
    }
}
