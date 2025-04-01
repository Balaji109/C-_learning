using System;
namespace Enter_User
{
    class Program
    {
        static void Main()
        {
            int user = 1;
            int [] A = new int[5];
            for (int i = 0; i < 5 && user !=0; i++)
            {
                user = int.Parse(Console.ReadLine());
                if (user != 0)
                {
                    Console.WriteLine(user);
                    A[i] = user;
                }   
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadLine();
        }
    }
}
