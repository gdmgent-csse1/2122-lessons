using System;

namespace les2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            // Give me a number...
            for (int i = 0; i < 10; i++)
            {
                Step1();
            }
            Step2();
        }

        static void Step1()
        {
            WriteLine("Step1 busy executing...");
            string numberAsText = Console.ReadLine();
            int number = Convert.ToInt32(numberAsText);

            if(number == 0)
            {
                WriteLine("number == 0");
                WriteLine("" + number);
            }
            else
            {
                WriteLine("else");
                WriteLine("" + number);
            }
        }

        static void Step2()
        {
            WriteLine("Step2 busy executing...");    
        }
        static void WriteLine(string inputText)
        {
            Console.WriteLine(inputText);
        }

    }
}