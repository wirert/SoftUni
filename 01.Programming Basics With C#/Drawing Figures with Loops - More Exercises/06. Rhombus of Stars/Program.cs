﻿using System;

namespace _06._Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= n -row; i++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write($" *");
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n -1; row++)
            {
                for (int i = 0; i <= row - 1; i++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int i = 1; i < n - row ; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
