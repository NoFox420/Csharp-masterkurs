using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Maus : ITier
    {
        public string geschlecht { get; set; }
        public int alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Die Maus frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Die Maus trinkt!");
        }
    }
}
