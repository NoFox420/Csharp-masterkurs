using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Hund : ITier
    {
        public string geschlecht { get; set; }
        public int alter { get; set; }

        public void Fressen()
        {
            Console.WriteLine("Der Hund frisst!");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt!");
        }
    }
}
