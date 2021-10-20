using System;

namespace Exercise02
{
    class Program
    {
        int getal = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Product - Multiply.
            // Tafel van vermenigvuldiging -> product.

            int vermenigvuldigtal = Convert.ToInt32(Console.ReadLine());
            // a x b
            // a = vermenigvuldiger
            // b = vermenigvuldigtal
            int vermenigvuldiger = 2;
            int resultaat = Product(vermenigvuldiger, vermenigvuldigtal);
            Console.WriteLine("Resultaat product: " + resultaat);

            TafelsVanVermenigvuldiging(vermenigvuldigtal);
        }

        static int Product(int a, int b)
        {
            /*
                int resultaat = a * b;
                return resultaat;
            */
            return a * b;
        }

        static void TafelsVanVermenigvuldiging(int b)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(""+i + " x " + b + " = " + i*b);
            }

            for (int j = 0; j < length; j++)
            {
                
            }
        }

    }
}
