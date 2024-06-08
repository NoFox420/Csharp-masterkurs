using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    abstract class Arbeiter
    {
        public string Name { get; set; }
        public decimal Gehalt {  get; set; }

        public Arbeiter(string name, decimal gehalt)
        {
            Name = name;
            Gehalt = gehalt;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gehalt: " + Gehalt);
        }

        public abstract void ArbeitVerrichten();
        
    }
}
