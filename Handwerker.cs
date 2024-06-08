using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Handwerker : Arbeiter
    {
        public Handwerker(string name, decimal gehalt) : base(name, gehalt) { }
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Handwerker " + Name + " betritt das Haus des Kunden!");
            Console.WriteLine("Er repariert die Tür!");
        }
    }
}
