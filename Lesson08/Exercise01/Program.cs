using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Paard p = new Paard("Stipje");
            Console.WriteLine(p.ToString());
            p.Name = "Vlekje";
            Console.WriteLine(p.ToString());
            p.setName("Stipje");
            Console.WriteLine(p.getName());
            p.IsZoogdier = true;

            Generator.GenerateTest();
        }
    }

    public static class Generator
    {
        public static void GenerateTest()
        {
            Console.WriteLine("Test!");
        }
    }
    
    public class Dier
    {
        private Boolean isZoogdier;

        public Boolean IsZoogdier
        {
            get 
            {
                return this.isZoogdier;
            }
            set
            {
                this.isZoogdier = value;
            }
        }
    }

    public class Paard : Dier
    {
        // Velden
        private String name;

        // Properties
        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public String getName()
        {
            return this.name;
        }

        public void setName(String naam)
        {
            this.name = naam;
        }


        // Constructor
        public Paard()
        {
            
        }

        public Paard(String naam)
        {
            this.name = naam;
        }

        public void MaakGeluid()
        {
            Console.WriteLine("Paard maakt geluid...");
        }

        public override String ToString()
        {
            return "Naam van het paard: " + this.name;
        }


    }
}


