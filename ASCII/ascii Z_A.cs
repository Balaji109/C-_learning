using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 26; i++)
            {
                int j = 90 - i ;
                Console.WriteLine((char)j);

            }
            Console.ReadLine(); 
            
        }
    }
}
