﻿using System;

namespace Практика_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;
            int k=0;
            for (int i = 0; i < 7; i++)
            {
                 array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                k++;
            }
            Console.WriteLine(((double)s)/k);
            Console.ReadKey();
        }
    }
}
