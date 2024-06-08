
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rechteck = new Rectangle(10, 20);
            rechteck.GetArea();

            Circle kreis = new Circle(3);
            kreis.GetArea();

            Console.WriteLine(rechteck.GetArea());
            Console.WriteLine(rechteck.ToString());

            Console.WriteLine();

            Console.WriteLine(kreis.GetArea());
            Console.WriteLine(kreis.ToString());
        }
    }
}
