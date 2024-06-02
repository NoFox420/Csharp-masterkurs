using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Auto : IKraftfahrzeug
    {
        //Eigenschaften und Methoden des Interfaces implementieren
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }

        public void Fahren()
        {
            Console.WriteLine("Das Auto fährt!");
        }
        public void Bremsen()
        {
            Console.WriteLine("Das Auto bremst!");
        }
    }
}
