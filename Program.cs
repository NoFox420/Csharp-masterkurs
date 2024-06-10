
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
            //Objekt erstellen mit pfad und bool für append parameter
            string pfad = @"C:\Users\janfr\OneDrive\Desktop\TestOrdner\TestDatei.txt";

            //vereinfachte methode um in eine datei zu schreiben, schließt den stream automatisch
            using (StreamWriter sw = new StreamWriter(pfad, true))
            {
                //öffnet einen Stream und schreibt in datei
                sw.WriteLine("");
                sw.WriteLine("Hallo mein Name ist Jani");
            }
        }
    }
}
