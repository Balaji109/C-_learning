using System;
namespace a_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 26; i++)
            {
                int k = 97 + i;
                int j = 65 + i ;
                Console.WriteLine((char)k);
                Console.WriteLine((char)j);

            }
            Console.ReadLine(); 
            
        }
    }
}
