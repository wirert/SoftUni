﻿using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 1; i <= n * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <= n)
                    leftSum += num;
                else
                    rightSum += num;
            }
            if (leftSum == rightSum)
                Console.WriteLine($"Yes, sum = {leftSum}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
        }
    }
}
