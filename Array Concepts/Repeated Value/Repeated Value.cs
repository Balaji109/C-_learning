using System;
using System.Net.Mime;
namespace Enter_User
{
    class Program
    {
        static void Main()
        {
            int user = 1;
            int[] A = new int[5];
            for (int i = 0; i < 5 && user != 0; i++)
            {
                user = int.Parse(Console.ReadLine());
                if (user != 0)
                {
                    Console.WriteLine(user);
                    A[i] = user;
                }
            }

            Console.Write("{");
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != 0)
                {
                    Console.Write(A[i]);
                }
            }
            Console.WriteLine("}");
            int Repeat = 0;
            int Max = 0;
            int User = int.Parse(Console.ReadLine());
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == User)
                {
                    Repeat++;
                }
            }
            if (Repeat == 0)
            {
                Console.WriteLine("Number not Found");
            }            
            Console.WriteLine("Repeated times: " + Repeat);
            Console.ReadLine();
        }
    }
}
