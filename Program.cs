
using System;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ErbendeKlasse objekt = new ErbendeKlasse("Peter", 33);   

        }

    }

    class BasisKlasse
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public BasisKlasse(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("BasisKlassen Konstruktor wird ausgeführt!");
        }
    }

    class ErbendeKlasse : BasisKlasse
    {
        public ErbendeKlasse(string name, int age) : base(name, age)
        {
            Console.WriteLine("ErbendeKlasse Konstruktor wird ausgeführt!");
        }
    }


}
