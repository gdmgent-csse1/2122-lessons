using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Exercise02 - factorial
            // 6! = 1*2¨*3*4*5*6
            // More information: https://en.wikipedia.org/wiki/Factorial
            // Meer informatie: https://nl.wikipedia.org/wiki/Faculteit_(wiskunde)

            int number = 6;
            int inputNumber = number;
            int factWhile = number;
            
            while (number > 2)
            {
                number -= 1;
                factWhile *= number;
            }
            Console.WriteLine("Method 1 via While - Factorial of " + inputNumber + " is " + factWhile);

            // Reset number to initial value...
            number = 6;
            int factForLoop = 1;
            for (int i = 1; i < number+1; i++)
            {                
                factForLoop *= i;
            }

            Console.WriteLine("Method 2 via For-loop - Factorial of " + inputNumber + " is " + factForLoop);
}
    }
}
