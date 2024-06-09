
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections.Generic;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wertebehälter<string> behälter = new Wertebehälter<string>("Janek");
            behälter.WertAusgabe();

            Wertebehälter<int> behälter2 = new Wertebehälter<int>(3);
            behälter2.WertAusgabe();

        }
    }

    class Wertebehälter<T>
    {
        public T MeinWert { get; set; }

        public Wertebehälter(T wert)
        {
            MeinWert = wert;
        }

        public void WertAusgabe()
        {
            Console.WriteLine(MeinWert.ToString());
        }
    }
}
