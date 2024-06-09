
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
            List<string> namensListe = new List<string>();

            AddMultiple<string>(namensListe, 5, "Sabine");

            foreach (string names in namensListe)
            {
                Console.WriteLine(names);
            }
        }

        static void AddMultiple<T>(List<T> list, int amount, T value)
        {
            for (int i = 0; i < amount; i++)
            {
                list.Add(value);
            }

        }

    }
}
