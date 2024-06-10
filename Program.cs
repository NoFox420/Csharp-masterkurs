
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
            //Objektinstanz von Ordner erstellen
            string path = @"C:\\Users\\janfr\\OneDrive\\Desktop\\TestOrdner";
            DirectoryInfo verzeichnis = new DirectoryInfo(path);

            //Array aus Verzeichnissen vom path erstellen
            DirectoryInfo[] verzeichnisse = verzeichnis.GetDirectories();

            foreach (DirectoryInfo dir in verzeichnisse)
            {
                Console.WriteLine(dir.Name);
            }

            //Array aus Dateien vom path erstellen
            FileInfo[] dateien = verzeichnis.GetFiles();

            foreach (FileInfo datei in dateien) 
            {
                Console.WriteLine(datei.Name);
            }

            //Neuen Ordner erstellen
            string pfad = @"C:\\Users\\janfr\\OneDrive\\Desktop\\CREATEFOLDER";

            DirectoryInfo zweitesVerzeichnis = new DirectoryInfo(pfad);

            zweitesVerzeichnis.Delete(true);
        }
    }
}
