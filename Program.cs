
using System;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund coco = new Hund();
            coco.Name = "Coco";
            coco.Alter = 11;
            coco.Rasse = "Weißer Schäferhund";
            coco.Fressen();
            coco.Bellen();

            Wachhund jill = new Wachhund();
            jill.Name = "Jill";
            jill.Alter = 9;
            jill.Rasse = "Mischling";
            jill.BewacheHaus();
            jill.Fressen();
            jill.Bellen();

        }

    }

    class Hund
    {
        //Eigenschaften
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Rasse { get; set; }

        //Methoden
        public void Fressen()
        {
            Console.WriteLine("Der Hund " + Name + " frisst gerade!");
        }

        public void Bellen()
        {
            Console.WriteLine("Der Hund " + Name + " bellt gerade!");
        }
    }

    //Klasse erbt von andere Klasse
    //um von mehreren klassen zu erben interfaces benutzen
    class Wachhund : Hund
    {
        public void BewacheHaus()
        {
            Console.WriteLine("Der Hund " + Name + " bewacht das Haus!");
        }
    }


}
