
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund();
            hund.alter = 6;
            hund.geschlecht = "männlich";

            Katze katze = new Katze();
            katze.alter = 4;
            katze.geschlecht = "weiblich";

            Maus maus = new Maus();
            maus.alter = 5;
            maus.geschlecht = "weiblich";

            ITier[] tiere = new ITier[3];
            tiere[0] = hund;
            tiere[1] = katze;
            tiere[2] = maus;

            foreach (ITier tier in tiere) 
            {
                Console.WriteLine(tier.alter);
                Console.WriteLine(tier.geschlecht);
                tier.Fressen();
                tier.Trinken();
                Console.WriteLine();
            }
        }
    }
}
