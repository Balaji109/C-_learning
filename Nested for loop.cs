﻿using System;
namespace Pattern1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                
                for (int j = 1; j < m + 1; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
