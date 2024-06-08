
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Hund1 = new Dog("Howard", 4);
            Console.WriteLine("Name: " + Hund1.Name);
            Console.WriteLine("Alter: " + Hund1.Age);
            Console.WriteLine("Besitzer: " + Hund1.Owner);
        }

        
    }

    
}
