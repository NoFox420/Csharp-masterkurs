
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections.Generic;

namespace Csharp_masterkurs

{
    public delegate void AusgabeDelegate(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            AusgabeDelegate ausgabe = new AusgabeDelegate(SayHello);

            ausgabe += SayGoodbye;

            ausgabe("Peter");
        }

        static void SayHello(string name)
        {
            Console.WriteLine(name + " sagt hallo!");
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine(name + " verabschiedet sich!");
        }
    }
}
