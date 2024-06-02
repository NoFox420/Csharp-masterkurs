using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal interface IKraftfahrzeug
    {
        //Eigenschaften
        string Hersteller { get; set; }
        int MaxGeschwindigkeit { get; set; }

        //Methoden
        void Fahren();
        void Bremsen();
    }
}
