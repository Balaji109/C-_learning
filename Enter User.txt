using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_User
{
    class Program
    {
        static void Main()
        {
            int user = 1;
            for (int i = 0; i < 5 && user !=0; i++)
            {
                user = int.Parse(Console.ReadLine());
                if (user != 0)
                {
                    Console.WriteLine(user);
                }  
            }
            Console.ReadLine();
        }
    }
}
