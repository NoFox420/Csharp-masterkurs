using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Motorrad : IKraftfahrzeug
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }

        public void Bremsen()
        {
            Console.WriteLine("Das Motorrad bremst!");
        }

        public void Fahren()
        {
            Console.WriteLine("Das Motorrad fährt!");
        }
    }
}
