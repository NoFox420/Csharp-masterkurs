namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eigene statische Klasse
            double fläche = Mathematik.RechteckFläche(10, 15);
            Console.WriteLine(fläche);

            //statische Klassen vom .NET-Framwork:
            double squareRoot = Math.Sqrt(50);
            Console.WriteLine(squareRoot);

        }

    }

    static class Mathematik
    {
        public static double RechteckFläche(double breite, double höhe)
        {
            return breite * höhe;
        }
    }

       
}