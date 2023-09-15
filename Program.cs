namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl = Addition(10, 5);
            Console.WriteLine(zahl);
        }
        
        //static weil nicht objekt basiert
        //int definiert den rückgabewert datentyp
        static int Addition(int num1, int num2)
        {
            int ergebnis = num1 + num2;
            return ergebnis;
        }
    }
}