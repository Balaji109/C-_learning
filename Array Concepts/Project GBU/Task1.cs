using System;
using System.IO;

namespace Project_GBU
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

            for (int i = 0; i < input.Length && Verification; i++)
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
        static void Screen_Data_Collection()
        {
            string Name = "";
            Console.Write("Enter a Name: ");
            Name = Console.ReadLine();            
            bool Valid_name;
            Valid_name = Valid_Input_OR_Not(Name);
            while (!Valid_name)
            {
                Console.Clear();
                Console.WriteLine("Please enter a Valid input");
                Console.ReadLine();
                Console.Clear();
                Console.Write("Enter a Name: ");
                Name = Console.ReadLine();
                Valid_name = Valid_Input_OR_Not(Name);
                
            }
            using (StreamWriter sw = File.AppendText("File.txt"))
            {
                sw.WriteLine("Name:" + Name);
            }
            Console.Write("Enter the Std: ");
            int Std = int.Parse(Console.ReadLine());
            using (StreamWriter sw = File.AppendText("File.txt"))
            {
                sw.WriteLine("Std:" + Std);
            }
            Console.Write("Enter the number of Subjects: ");
            int Number_of_Subjects = int.Parse(Console.ReadLine());
            string Subject_Name = "";
            //int subject_marks = int.Parse(Console.ReadLine());
            for (int i = 1; i < Number_of_Subjects + 1; i++)
            {
                Console.Write("Name of the subjects " + i + ":");
                Subject_Name = Console.ReadLine();
                using (StreamWriter sw = File.AppendText("File.txt"))
                {
                    sw.WriteLine("subject name:" + Subject_Name);
                }
                Console.Write("Marks of the subjects: ");
                int subject_marks = int.Parse(Console.ReadLine());
                using (StreamWriter sw = File.AppendText("File.txt"))
                {
                    sw.WriteLine("subject marks:" + subject_marks);
                }
            }


            Console.ReadLine();

        }
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

            while (Selection != 2)
            {
                if (Selection == 1)
                {
                    //Console.Write("Please Enter Name: ");
                    //Name = Console.ReadLine();
                    //using (StreamWriter sw = File.AppendText("File.txt"))
                    //{
                    //    sw.WriteLine(Name);                        
                    //}
                    Screen_Data_Collection();
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
