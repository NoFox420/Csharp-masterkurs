using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal interface ITier
    {
        string geschlecht { get; set; }
        int alter {  get; set; }

        void Fressen();
        void Trinken();
    }
}
