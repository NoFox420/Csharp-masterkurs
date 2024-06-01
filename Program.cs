
using System;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund coco = new Hund("Coco", 12, "weißer Schäferhund", "Männlich");

            Console.WriteLine(coco.Name);
            Console.WriteLine(coco.Age);
            coco.Bellen();
            coco.Fressen();
        }
    }

    class Hund
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Rasse { get; set; }
        public string Geschlecht { get; set; }

        public Hund(string name, int age, string rasse, string geschlecht)
        {
            Name = name;
            Age = age;
            Rasse = rasse;
            Geschlecht = geschlecht;
        }

        public void Bellen()
        {
            Console.WriteLine(Name + " bellt!");
        }

        public void Fressen()
        {
            Console.WriteLine(Name + " frisst!");
        }
    }

    //class ErbendeKlasse : BasisKlasse
    //{
    //    public ErbendeKlasse(string name, int age) : base(name, age)
    //    {
    //        Console.WriteLine("ErbendeKlasse Konstruktor wird ausgeführt!");
    //    }
    //}


}
