﻿using System;


namespace Csharp_masterkurs
{
    [Serializable]
    internal class Transaction
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Transaction(string name, decimal amount, DateTime date)
        {
            Name = name;
            Amount = amount;
            Date = date;
        }

        public override string ToString()
        {
            return "Name: " + Name + " | Datum: " + Date.ToShortDateString() + " | Betrag: " + Amount + " Euro";
        }
    }
}
