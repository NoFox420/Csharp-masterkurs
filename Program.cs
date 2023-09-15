namespace Csharp_masterkurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe einen Radius ein: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double result = GetCircleArea(radius);
            Console.WriteLine("Die Fläche eines Kreises mit dem Radius {0}cm beträgt {1}cm²!", radius, result);
        }

        static double GetCircleArea(double radius)
        {

            return Math.PI * radius*radius;
        }
        
    }
}