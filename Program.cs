namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib deinen Anfangsparameter ein: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib deinen Endparameter ein: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            AllEvenNumbers(num1, num2);

        }

        static void AllEvenNumbers(int num1, int num2)
        {
            Console.WriteLine("Gerade Zahlen zwischen deinen Parametern:");

            while (num1 <= num2) {
                if (num1 % 2 == 0) Console.WriteLine(num1);
                num1++;
            }

        }





    }
}