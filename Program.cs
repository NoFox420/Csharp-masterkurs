namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Jahreszahl ein: ");

            int year = Convert.ToInt32(Console.ReadLine());

            CalculateLeapYear(year);

        }

        static void CalculateLeapYear(int year)
        {
            bool lYear = false;

            if (year % 4 == 0) { lYear = true; }
            else if (year % 100 == 0) { lYear = false; }
            if (year % 400 == 0) { lYear = true;}
            else
            {
                Console.WriteLine("Ungültige eingabe!");
            }

            switch (lYear) {
                case
                    true:
                    
                        Console.WriteLine("Schaltjahr");
                        break;
                    
                case 
                    false:  Console.WriteLine("Kein Schaltjahr");
                        break;
                    
            }
        }
        

        
    }
}