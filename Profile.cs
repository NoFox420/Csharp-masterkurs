using System;
using System.Collections.Generic;


namespace Csharp_masterkurs
{
    [Serializable]
    internal class Profile : Menu
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public List<Transaction> Transactions { get; private set; }

        public Profile(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            Balance += transaction.Amount;
            ProfileManager.SaveProfile(this);
        }

        public override void DisplayMenu()
        {
            Console.WriteLine("Profil: ");
            Console.WriteLine("Aktueller Kontostand: ");
            Console.WriteLine("----------");
            Console.WriteLine("[1] Neue Transaktion");
            Console.WriteLine("[2] Zeige Transaktionen");
            Console.WriteLine("[3] Zurück ins Hauptmenü");

            InputOption();

        }

        private void InputOption()
        {
            string input;
            Menu nextMenu;

            Console.Write("Eingabe: ");
            input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    //nextMenu = new NewTransactionMenu();
                    break;

                case "2":
                    //nextMenu = new Transaction();
                    break;

                case "3":
                    nextMenu = new StartMenu();
                    break;

                default:
                    break;

            }
        }
    }
}
