using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Exercise01
            int numberInt = 4;
            float numberFloat = 3.0000000001F;
            Console.WriteLine(numberFloat);
            int numberFloatToInt = (int)numberFloat;
            Console.WriteLine(numberFloatToInt);
            double numberDouble = 1.00000005;
            Console.WriteLine(numberDouble);
            decimal numberDecimal = 1.00000005M;
            Console.WriteLine(numberDecimal);

            //Conversion of F to C
            //https://www.google.com/search?q=fahrenheit+to+celsius+formula&rlz=1C1CHBF_nlBE923BE923&sxsrf=AOaemvKKYsWjxjhtfOmbJhiD2oVGur7ZHQ%3A1634121316914&ei=ZLZmYaqaN7yK9u8Pq4qr2As&oq=fahrenheit+to+celsius+formula&gs_lcp=Cgdnd3Mtd2l6EAMYATIICAAQgAQQsQMyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQ6BwgAEEcQsAM6BAgjECc6BggAEBYQHkoECEEYAFDADVieGmD7JGgBcAJ4AIABXYgBtwOSAQE2mAEAoAEByAEIwAEB&sclient=gws-wiz
            int fahrenheitInt = 100;
            int celsiusInt = (fahrenheitInt - 32) * (5 / 9);
            Console.WriteLine("Celsius Int " + celsiusInt);
            double fahrenheitDouble = 100;
            double celsiusDouble = (fahrenheitDouble - 32) * (5.0/9.0);
            Console.WriteLine("Celsius Double " + celsiusDouble);

            bool myBoolean = true;
            //int booleanValue = (int)myBoolean;

            char charA = 'a';
            charA = 'b';
            Console.WriteLine(charA);
            string text = "Hello World CSSE1!";
            Console.WriteLine("The text is: " + text);
            foreach (var item in text.ToCharArray())
            {
                Console.WriteLine("The char is: " + item);
            }

            char char1 = '1';
            char charSign = '.';
            byte memoryCharSign = Convert.ToByte(charSign);
            Console.WriteLine(memoryCharSign);
            int test = 'm';
            Console.WriteLine(test);
        }
    }
}
