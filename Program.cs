namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanziierung der variable
            Bankkonto konto = new Bankkonto();
            Bankkonto konto2 = new Bankkonto();

            //zugriff auf die eigenschaften und methoden
            konto.Kontostand = 2500;
            konto.Besitzer = "Sandra Müller";
            konto.Auszahlen(250);

            konto2.Kontostand = 3000;

            Console.WriteLine("Kontostand 1: " + konto.Kontostand);
            Console.WriteLine("Kontostand 2: " + konto2.Kontostand);


        }

    }
}