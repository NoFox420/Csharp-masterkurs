
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewPerson jens = new NewPerson("Jens", "Bauer");
            jens.Greet();

            NewPerson sabrina = new NewPerson("Sabrina", "Müller");
            jens.Greet(sabrina);
        }
    }
}
