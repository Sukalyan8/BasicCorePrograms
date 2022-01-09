using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientAndRemainder
    {
        public static void ComputeQuotientAndReminder()
        {
            Console.WriteLine("enter the value of dividend and divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int dividend = Convert.ToInt32(Console.ReadLine());
            double quotient = dividend / divisor;
            double reminder = dividend % divisor;
            Console.WriteLine("Quotient=" + quotient + "\n Reminder=" + reminder);
        }
    }
}
