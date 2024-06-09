
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personen person1 = new Personen("Dirk Maier", Geschlecht.Männlich);
            Console.WriteLine(person1.Geschlecht);
        }     
    }    

    enum Geschlecht
    {
        Männlich,
        Weiblich,
        Divers
    }

    class Personen
    {
        public string Name { get; set; }
        public Geschlecht Geschlecht { get; set; }

        public Personen (string name, Geschlecht geschlecht) 
        {
            Name = name;
            Geschlecht = geschlecht;
        }
    }
}
