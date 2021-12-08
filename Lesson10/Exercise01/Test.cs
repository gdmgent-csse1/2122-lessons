using System;

namespace CSSEI
{
    //Klassen moeten voor interfaces komen!
    //class Test : Logging, ILogging
    public class Test : Logging, ILogging
    {   
        // Fields
        private string description;

        // Properties
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Constructor
        private Test()
        {
            //Logging log = new Logging();
            this.IsLogActive = true;
        }

        public Test(string descr)
        {
            this.Description = descr;
        }

        // Methods
        public void DoTest()
        {
            Console.WriteLine("This is a test!");
            if(this.IsLogActive)
                WriteLog();
        }

        /*
       public string DoTest()
       {
           return "This is a test!";
       }

       public void DoTest(string text)
       {
           Console.WriteLine("Test: " + text);
       }

       public string DoTest(string text)
       {
           return "Test: " + text;
       }

       public string DoTest(int testCount)
       {
           return "Test: " + testCount;
       }
*/

        public override void PrintLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Test2");
        }

        public void WriteLog()
        {
            //throw new NotImplementedException();
            PrintLog();
            this.PrintLog("Test");
        }
    }
}