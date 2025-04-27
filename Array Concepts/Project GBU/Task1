using System;
using System.IO;

namespace Project_GBU
{
    class Program
    {
        static void Main()
        {    
            Console.WriteLine("Press 1 to Enter data");
            Console.WriteLine("Press 2 to Exit");
            int Selection = int.Parse(Console.ReadLine());
            Console.Clear();
            if (Selection != 1 && Selection != 2)
            {
                Console.WriteLine("please Enter a Valid input");
            }
            string Name = "";
            while (Selection != 2)
            {
                if (Selection == 1)
                {
                    Console.Write("Please Enter Name: ");
                    Name = Console.ReadLine();
                    using (StreamWriter sw = File.AppendText("File.txt"))
                    {
                        sw.WriteLine(Name);                        
                    }
                    Console.Clear();          
                }
                Console.WriteLine("Press 1 to Enter data");
                Console.WriteLine("Press 2 to Exit");
                Selection = int.Parse(Console.ReadLine());
                Console.Clear();
                if (Selection != 1 && Selection != 2)
                {
                    Console.WriteLine("please Enter a Valid input");
                }

            }                        
        }
        
    }
}
