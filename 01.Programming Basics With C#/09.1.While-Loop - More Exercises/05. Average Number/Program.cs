﻿using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int j = int.Parse(Console.ReadLine());
                sum += j;
            }
            Console.WriteLine($"{(double)sum / n:f2}");
        }
    }
}
