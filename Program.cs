
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
            //List erstellen und Methode einbinden
            BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Sabrina");
            names.Add("Alina");
            names.Add("Peter");
            names.Add("Uwe");


        }

        static void OnAdded()
        {
            Console.WriteLine("Ein Objekt wurde zur List hinzugefügt...");
        }
    }

    //Delegaten instanziieren für Event
    delegate void AddedEventHandler();

    //Generische List mit Platzhalter für Datentypen definieren
    class BetterList<T> : List<T>
    {
        //Add Methode der List Klasse wird erweitert mit einem Event
        public new void Add(T item)
        {
            //Eigentliche Funktionalität der Methode wird hinzugefügt
            base.Add(item);

            //Prüfen ob methoden dieses event abonniert haben
            if (Added != null) 
            {
                //Event wird aufgerufen
                Added();
            }
        }

        //Event erstellen der delegate nutzt
        public event AddedEventHandler Added;
    }
}
