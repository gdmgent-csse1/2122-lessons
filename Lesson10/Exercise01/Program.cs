using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CSSEI.Test t = new CSSEI.Test();
            CSSEI.Test t = new CSSEI.Test("CSSEI - Les 10");
            //t.IsLogActive = true;
            t.WriteLog();
            t.PrintLog();
            t.PrintLog("TEST");
        }
    }
}