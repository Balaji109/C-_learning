using System;


namespace ConsoleApp9
{
    class Program
    {
        static bool Valid_Input_OR_Not(string Student_Name)
        {
            char[] input = Student_Name.ToCharArray();
            bool Verification = true;
            if (input.Length == 0 || input[0] == ' ')
            {
                Verification = false;
                Console.WriteLine("please Enter a Valid input");
            }

            for (int i = 0; i < input.Length && Verification ; i++)
            {
                if ((input[i] < 'A' || input[i] > 'Z') &&
                    (input[i] < 'a' || input[i] > 'z') &&
                    (input[i] != ' '))
                {
                    Verification = false;
                    Console.WriteLine("please Enter a Valid input");
                }
            }
            
            return Verification;
        }
        static void Main()
        {
            bool Gun;
            string Student_Name = Console.ReadLine();
            Gun = Valid_Input_OR_Not(Student_Name);
            while (!Gun)
            {
                Student_Name = Console.ReadLine();
                Gun = Valid_Input_OR_Not(Student_Name);
            }
            Console.WriteLine(Gun);
            Console.ReadLine();
        }

        

           

            
        
    }
}

