
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
            while (true)
            {
                int alter = 0;
                try
                {
                    Console.Write("Gebe dein Alter ein: ");
                    alter = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Du musst eine gültige Zahl eingeben!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Gebe ein normales Alter ein!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (alter >= 18)
                {
                    Console.WriteLine("Du bist volljährig!");
                }
                else
                {
                    Console.WriteLine("Du bist minderjährig!");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
