
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
            //6. List erstellen und Methode einbinden
            BetterList<string> names = new BetterList<string>();

            //8. Added Event mit OnAdded Methode abonnieren
            names.Added += OnAdded;

            names.Add("Sabrina");
            names.Add("Alina");
            names.Add("Peter");
            names.Add("Uwe");
        }

        //7. Event Handler Methode
        static void OnAdded(object sender, AddedEventArgs args)
        {
            Console.WriteLine("Das Objekt: " + args.AddedItem.ToString() + " wurde hinzugefügt.");
        }
    }

    //3. Delegaten instanziieren für Event
    delegate void AddedEventHandler(object sender, AddedEventArgs args);

    //1. Generische List mit Platzhalter für Datentypen definieren
    class BetterList<T> : List<T>
    {
        //2. Add Methode der List Klasse wird erweitert mit einem Event
        public new void Add(T item)
        {
            //Eigentliche Funktionalität der Methode wird hinzugefügt
            base.Add(item);
            //Event wird aufgerufen
            OnAdded(item);
        }

        //4. Event erstellen der delegate nutzt
        public event AddedEventHandler Added;

        //5. Methode um Event zu starten
        private void OnAdded(T item)
        {
            //Prüfen ob methoden dieses event abonniert haben
            if (Added != null)
            {
                //Event wird aufgerufen
                Added(this, new AddedEventArgs(item));
            }
        }
    }

    //Klasse erstellen die 
    class AddedEventArgs : EventArgs 
    {
        public object AddedItem { get; set; }

        public AddedEventArgs(object addedItem)
        {
            AddedItem = addedItem;
        }
    }
}
