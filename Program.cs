namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IMPLIZITE KONVERTIERUNG
                //erfolgt automatisch, compiler weiß wann er konvertieren muss
                //funktioniert von numerischem zu numerischem datentypen
                //datenverlust muss ausgeschlossen sein

            int zahl1 = 15;
            double zahl2 = zahl1; //funktioniert

            double zahl3 = 15;
            float zahl4 = zahl3; //funktioniert nicht


            //EXPLIZITE KONVERTIERUNG
                //wenn implizit nicht möglich ist
                //nur anwenden wenn datenverlust auszuschließen ist
                //verwendung von cast-operator

            double zahl5 = 3.1459;
            float zahl6 = zahl5; //funktioniert nicht

            double zahl7 = 3.1459;
            float zahl8 = (float)zahl7; //funktioniert
        }

    }
}