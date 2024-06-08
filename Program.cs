
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] {10, 5, 20, 30};
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Sum(10, 5));
        }

        static double Sum(double a, double b)
        {
            return a + b; 
        }

        static double Sum(double[] numbers) 
        {
            double sum = 0;

            foreach (double number in numbers) 
            {
                sum += number;
            }

            return sum;
        }
    }

    
}
