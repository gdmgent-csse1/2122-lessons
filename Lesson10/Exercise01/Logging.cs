using System;

namespace CSSEI
{
    public abstract class Logging
    {

        // Fields
        bool isLogActive;
        //abstract bool isLoggingActive;

        public bool IsLogActive
        {
            get { return isLogActive; }
            set { isLogActive = value; }
        }

        // Methods
        public abstract void PrintLog();

        public void PrintLog(string text)
        {
            Console.WriteLine("Log: " + text);
        }
    }
}