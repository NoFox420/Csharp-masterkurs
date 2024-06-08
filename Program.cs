
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mechatroniker jens = new Mechatroniker("Jens", 2500);
            jens.PrintInformation();
            jens.ArbeitVerrichten();

            Handwerker christian = new Handwerker("Christian", 2000);
            christian.PrintInformation();
            christian.ArbeitVerrichten();
        }
    }
}
