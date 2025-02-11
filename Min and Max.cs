using System;

namespace Find_a_min_and_Max
{
class Program
    {
        static void Main()
        {
            int[] a = { 9, 2, 45, 32, 47, 23, 1 };
            int Temp = a[0];
            for (int i = 1; i < 7; i++)
            {
                if (Temp > a[i]) 
                {
                    Temp = a[i];
                }
                
            }
            Console.WriteLine("Min:" + Temp);
            for (int i = 1; i < 7; i++)
            {
                if (Temp < a[i])
                {
                    Temp = a[i];
                }

            }
            Console.WriteLine("Max:" + Temp);
        }
     }
}
