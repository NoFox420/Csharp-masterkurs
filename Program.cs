
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
            List<string> names = new List<string>();

            names.Add("Peter");
            names.Add("Alina");
            names.Add("Sabine");
            names.Add("Florian");

            Console.WriteLine("Unsortiert!");
            Console.WriteLine("--------------------");
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            names.Sort();

            Console.WriteLine("Sortiert");
            Console.WriteLine("--------------------");
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }

        }     
    }      
}
