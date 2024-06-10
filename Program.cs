
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
            string[] städteListe = new string[4];

            städteListe[0] = "Berlin";
            städteListe[1] = "Ingolstadt";
            städteListe[2] = "Düsseldorf";
            städteListe[3] = "Duisburg";

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {

                int index = rnd.Next(0, städteListe.Length);

                Console.WriteLine(städteListe[index]);
            }
        }
    }
}
