
using System;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dreieck: " + AreaCalculator.GetTriangleArea(5, 12));
            Console.WriteLine("Rechteck: " + AreaCalculator.GetRectangleArea(10, 4));
            Console.WriteLine("Quadrat: " + AreaCalculator.GetSquareArea(4));
            Console.WriteLine("Kreis: " + AreaCalculator.GetCircleArea(10));
        }
    }

    static class AreaCalculator
    {
        public static double GetTriangleArea(double triangleBase, double height)
        {
            return (triangleBase * height) / 2;
        }

        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double GetSquareArea(double length)
        {
            return length * length;
        }

        public static double GetCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }
    }
}
