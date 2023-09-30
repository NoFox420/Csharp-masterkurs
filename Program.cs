namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib gibt die erste Zahl ein: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gib eine Rechenoperation ein: ");

            string math = Console.ReadLine().ToLower();

            Console.WriteLine("Gib gibt die zweite Zahl ein: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (math)
            {
                case "addition": double sum1 = num1 + num2;
                    Console.WriteLine(sum1);
                    break;

                case "subtraktion": double sum2 = num1 - num2;
                    Console.WriteLine(sum2);
                    break;

                case "multiplikation": double sum3 = num1 * num2;
                    Console.WriteLine(sum3);
                    break;

                case "division": double sum4 = num1 / num2;
                    Console.WriteLine(sum4);
                    break;

                default: Console.WriteLine("falsche eingabe");
                    break;
            }
        }

        

        
        

        
    }
}