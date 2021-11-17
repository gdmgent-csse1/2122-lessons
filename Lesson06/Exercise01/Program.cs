using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int getal;
            getal = 5;
            getal += 3;
            Console.WriteLine("Hello World! " + getal);
            */

            Console.WriteLine("Start demo Datacollecties...");

            string[] merken = new string[5]{ "Coca-Cola", "Duvel", "Logitech", "Dell", "Apple" };
           /*
            int length = merken.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("merk"+i);
                merken[i] = "merk" + i;
            }
            */

            int length = merken.Length;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(""+merken[i]);
            }

            string[,] computers = new string[3,2]{{"Dell", "3560"}, {"Apple", "MacBook M2"}, {"HP", "P954"}};
            //int length1D = computers.Length;
            //Console.WriteLine(length1D);
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("TEST FOR-FOR LOOPS:" + computers[i, j] + "-" +  computers[i, j]);
                }
            }

            foreach (var item in computers)
            {
                Console.WriteLine("FOREACH" + item);
            }

           //string[,] 2darray = new string[3, 2] { { "BMW", "520" }, { "Golf", "1,9 TDI" },{ "Mercedes-Benz", "E 200" } };

        }
    }
}
