
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections.Generic;

namespace Csharp_masterkurs

{
    //Delegate nimmt string als Parameter an und returned einen boolean
    public delegate bool FilterDelegate(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string>()
            {
                "Horst",
                "Alina",
                "Hendrik",
                "Kai",
                "Janek",
                "Peter"
            };

            List<string> newList = ReturnNewList(namen, StartsWithH);

            foreach (string name in newList)
            {
                Console.WriteLine(name);
            }
        }

        //Methode nimmt ungefilterte Liste an
        static List<string> ReturnNewList(List<string> original, FilterDelegate filterMethod)
        {
            //neue Liste wird erstellt
            List <string> newList = new List<string>();

            //durchlaufen die originale Liste
            foreach (string str in original)
            {
                //string wird der Delegate übergeben
                if(filterMethod(str) == true) 
                { 
                    newList.Add(str);
                }
            }
            return newList;
        }

        //Filtermethoden die boolean returned
        static bool StartsWithH(string str) 
        {
            return (str[0] == 'H' || str[0] == 'h');
        }
    }
}
