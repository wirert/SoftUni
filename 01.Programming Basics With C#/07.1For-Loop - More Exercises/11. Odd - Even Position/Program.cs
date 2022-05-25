﻿using System;

namespace _11._Odd___Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double evenSum = 0;
            double oddMax = double.MinValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenMin = double.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                        evenMax = num;
                    if (num < evenMin)
                        evenMin = num;
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                        oddMax = num;
                    if (num < oddMin)
                        oddMin = num;
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue && oddMax == double.MinValue)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == double.MaxValue && evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
