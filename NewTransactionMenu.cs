using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class NewTransactionMenu : Menu
    {
        public override void DisplayMenu()
        {
            Menu nextMenu;

            Console.WriteLine("Neue Transaktion");
            Console.WriteLine("----------");

            string newTransactionName = InputTransactionName();
            decimal newTransactionAmount = InputTransactionAmount();
            DateTime newTransactionDate = InputTransactionDate();

            Transaction transaction = new Transaction(newTransactionName, newTransactionAmount, newTransactionDate);    
            
            ProfileManager.CurrentProfile.AddTransaction(transaction);
            Console.WriteLine("Die folgende Transaktion wurde hinzugefügt");

            if (transaction.Amount < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(transaction.ToString());
            Console.ForegroundColor= ConsoleColor.White;

            Console.ReadKey();
            nextMenu = new MainMenu();

        }

        private string InputTransactionName()
        {
            Console.Write("Transaktions-Name: ");
            return Console.ReadLine();
        }

        private decimal InputTransactionAmount()
        {
            decimal input;

            while (true)
            {
                Console.Write("Euro-Betrag: ");
                bool correctInput = true;

                if (!decimal.TryParse(Console.ReadLine(), out input))
                {
                    correctInput = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEHLER: Ungültiger Euro-Betrag");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (correctInput) 
                {
                    break;
                }
            }
            return input;
        }

        private DateTime InputTransactionDate()
        {
            DateTime input;

            while (true) 
            {
                Console.Write("Datum (TT.MM.JJJJ): ");
                bool correctInput = true;

                if(!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out input)) 
                {
                    correctInput = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEHLER: Ungültiges Datum");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (correctInput)
                {
                    break;
                }
            }
            return input;
        }
    }
}
