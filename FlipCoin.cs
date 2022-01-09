using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());

            if (flipCoin>=0)
            {
                for (int i =1; i <=flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 1)
                    {
                        Head = 1;
                        HeadCount += Head;
                    }
                    else if (number == 0)
                    {
                        Tail = 1;
                        TailCount += Tail;
                    }
                    Console.WriteLine(number);
                }
                    Console.WriteLine("----------");

                    HeadPercentage = (HeadCount * 100) / flipCoin;
                    TailPercentage = (TailCount * 100) / flipCoin;

                    Console.WriteLine("Head Percentage : " + HeadPercentage);
                    Console.WriteLine("Tail Percentage : " + TailPercentage);
                }

            else
                {
                    Console.WriteLine("Please enter the positive number");
                }
            }
        }
    }