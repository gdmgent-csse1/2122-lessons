using System;

namespace CSSEI
{
    static class Helper
    {

        // Methods
        public static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 100);
        }

    }
}