namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {

                Console.Write("Gib deine erste Zahl ein: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gib deinen Rechenoperator ein: ");
                char operation = Convert.ToChar(Console.ReadLine());

                Console.Write("Gib deine zweite Zahl ein: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                Calculation(num1, num2, operation);

            }
        }

        static void Calculation (double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+': double sum1 = num1 + num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, sum1);
                    break;

                case '-':
                    double sum2 = num1 - num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, sum2);
                    break;

                case '*':
                    double sum3 = num1 * num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, sum3);
                    break;

                case '/':
                    double sum4 = num1 / num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, sum4);
                    break;

                default: Console.WriteLine("Ungültige Eingabe!");
                    break;
            }
        }




    }
}