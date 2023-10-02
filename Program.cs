namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

                Console.Write("Gib deine Zahl ein: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Calculation(num1);

            
        }

        static void Calculation (int num1)
        {
            for (int i = 1; i <= 10;  i++)
            {
                int result = num1 * i;
                Console.WriteLine("{0} * {1} = {2}", num1, i, result);
            }
        }




    }
}