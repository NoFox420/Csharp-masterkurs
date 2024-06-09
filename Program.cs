
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

            //Neue, gefilterte Liste wird erstellt, nimmt originale Liste und Filtermethode an
            //Anonyme Filtermethode wird in der Parameterliste erstellt und der Delegate übergeben
            List<string> newList = ReturnNewList(namen, delegate (string name) { return name[0] == 'H'; });

            //gefilterte Liste wird ausgegeben
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
    }
}
