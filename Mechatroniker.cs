using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Mechatroniker : Arbeiter
    {
        public Mechatroniker(string name, decimal gehalt) : base(name, gehalt) 
        {
        }
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Mechatroniker " + Name + " betritt die Werkstatt");
            Console.WriteLine("Er arbeitet dort mit Autos!");
        }
    }
}
