namespace CSSEI
{
    interface ILogging
    {

        // Fields
        //bool isLoggingActive;

        // Methods
        public void WriteLog();

    }
}

// Kan alleen abstracte mehoden bevatten, maar abstract keyword gebruiken mag niet.
// Niet de bedoeling om fields te gebruiken.
// Geen constructor.