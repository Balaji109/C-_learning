using System;
namespace Pattern1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i++)
            {
                for (int j = n; j > i-1; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();

        }
    }
}
