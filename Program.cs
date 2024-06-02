
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto suv = new Auto();
            suv.Hersteller = "Audi";
            suv.MaxGeschwindigkeit = 180;

            EAuto limousine = new EAuto();
            limousine.Hersteller = "Tesla";
            limousine.MaxGeschwindigkeit = 140;

            Motorrad sport = new Motorrad();
            sport.Hersteller = "Suzuki";
            sport.MaxGeschwindigkeit = 250;

            IKraftfahrzeug[] fahrzeuge = new IKraftfahrzeug[3];
            fahrzeuge[0] = suv;
            fahrzeuge[1] = limousine;
            fahrzeuge[2] = sport;

            foreach (IKraftfahrzeug fahrzeug in fahrzeuge)
            {
                Console.WriteLine(fahrzeug.Hersteller);
                Console.WriteLine(fahrzeug.MaxGeschwindigkeit);
                fahrzeug.Fahren();
                fahrzeug.Bremsen();
                Console.WriteLine();
            }
            
        }
    }
}
