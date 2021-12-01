using System;

    public class Animal
    {

        // Fields
        private string name;

        // Properties
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Constructor

        public Animal()
        {
            // Wanneer we een instantie maken van de klasse dan dient er het volgende te gebeuren...
            this.MakeNoise("Booooh!!!");
        }

        public Animal(string nameAnimal)
        {
            // Wanneer we een instantie maken van de klasse dan dient er het volgende te gebeuren...
            this.MakeNoise("Miaauw!");
        }

        // Methods
        public void MakeNoise()
        {
            // The same but with the Format function....
            //Console.WriteLine("Noise is: " + noise );
            Console.WriteLine(String.Format("{0}", "This is a silent animal!"));
        }

        public void MakeNoise(string noise)
        {
            Console.WriteLine(String.Format("{0} {1}.", "Noise is:", noise));
        }

        public void MakeNoise(Boolean makeNoise)
        {
            if (makeNoise)
                Console.WriteLine(String.Format("{0}.", "This animal makes a noise"));
            else
                Console.WriteLine(String.Format("{0}.", "This animal makes no noise"));
        }

        public void MakeNoise(string noise1, string noise2)
        {
            Console.WriteLine(String.Format("{0} {1}.\n {2} {3}.", "The first noise is:", noise1, "And the second noise is:",noise2));
        }

    /*
    public string MakeNoise(string noise)
    {
        // The same but with the Format function....
        //Console.WriteLine("Noise is: " + noise );
        Console.WriteLine(String.Format("{0}{1}", "Noise is: ", noise));
    }
    */
}