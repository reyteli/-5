﻿using System;

namespace практика_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int[,] array = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ((i == j) || (i + j == n - 1) || (i + j == n - 3) || (j - i == n - 3) || (i + j== n + 1)) ? 1 : 0;
            Console.Write("{0}", array[i, j]);

                }
        Console.WriteLine();

            }
    Console.ReadKey();
	
        }
    }
}
