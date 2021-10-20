using System;

namespace Exercise01
{
    class Program
    {
        static int Getal = 3;
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                
                Console.WriteLine("Globale variabele Getal: " + Getal);
                int getal = 4;
                Console.WriteLine("Lokale variabele Getal: " + getal);
                getal = GeefGetal();
                Console.WriteLine("Lokale variabele Getal: " + getal);
                getal = GeefGetal(getal);
                Console.WriteLine("Lokale variabele Getal: " + getal);
                getal = GeefGetal(getal);
                Console.WriteLine("Lokale variabele Getal: " + getal);
                GeefGetal(ref getal);
                Console.WriteLine("Lokale variabele Getal: " + getal);
                //throw new InvalidOperationException();
                throw new SystemException();
                GeefGetalByRef(ref getal);
                Console.WriteLine("Lokale variabele Getal: " + getal);
                int input1, input2;
                GeefGetalOut(out input1, out input2);
                //Console.WriteLine("Getal 1 en 2: getal1: " + input1 + " - getal2: " + input2);
                Console.WriteLine("Getal 1 en 2: getal1: " + input2 + " - getal2: " + input1);
                GeefGetalIn(input1);
            }
            catch (System.InvalidOperationException ioe)
            {
                // Stappen uitvoeren voor het geval InvalidOperationException.
                Console.WriteLine("InvalidOperation EXCEPTION!!!");
                Console.WriteLine(ioe.Message);
            }
            catch(System.SystemException se)
            {
                Console.WriteLine("SYSTEMEXCEPTION!!!");
                Console.WriteLine(se.Message);
                Console.WriteLine(se.StackTrace);
            }
            catch (System.Exception e)
            {
                // Stappen uitvoeren voor het geval Exception.
                Console.WriteLine("BASE EXCEPTION!!!");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

            }

/*
            Exception
                - SystemException
                    - InvalidOperationException
                - ...

 */           
        }

        static int GeefGetal()
        {
            return 6;
        }
        static int GeefGetal(int input)
        {
            Console.WriteLine("zonder ref");
            return ++input;
        }

        static int GeefGetal(ref int input)
        {
            Console.WriteLine("met ref");
            if (input > 2)
            {
                return input;
            }
            else
            {
                Console.WriteLine("test");
                return 0;
            }
            //return ++input;
            //return 9;
        }

        static void GeefGetalByRef(ref int input)
        {
            input = 10;
            Console.WriteLine("met ref zonder return");
        }

        static void GeefGetalOut(out int getal2, out int getal1)
        {
            getal2 = 2;
            getal1 = 1;
            Console.WriteLine("met out");
        }

        static void GeefGetalIn(in int getal2)
        {
            int resultaat = getal2 + 5;
            Console.WriteLine("met in");
            Console.WriteLine("getal2: " + getal2 + "\nresultaat: "+ resultaat);
        }


    }
}
