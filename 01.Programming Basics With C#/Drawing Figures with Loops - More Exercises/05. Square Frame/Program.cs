﻿using System;

namespace _05._Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                    for (int j = 1; j <= n-2; j++)
                    {
                        Console.Write($"- ");
                    }
                    Console.Write("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write($"- ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}
