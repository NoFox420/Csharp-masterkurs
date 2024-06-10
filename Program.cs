
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objekt erstellen
            string pfad = @"C:\Users\janfr\OneDrive\Desktop\TestOrdner\TestDatei.txt";
            StreamReader sr = new StreamReader(pfad);

            //öffnet einen Stream und liest datei bis zum ende
            Console.WriteLine(sr.ReadToEnd());

            Console.WriteLine(sr.ReadLine());

            //stream schließen
            sr.Close();

        }
    }
}
