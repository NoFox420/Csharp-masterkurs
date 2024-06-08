
using System;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point punkt = new Point(10, 5);
            punkt.MovePosition(2, 2);
            
            Console.WriteLine(punkt.x + ", " + punkt.y);

            //Zeitdifferenz messen zwischen struct Point und class Point

            Stopwatch sw = new Stopwatch();

            Point[] punkte = new Point[10000000];

            sw.Start();

            for (int i = 0; i < punkte.Length; i++)
            {
                punkte[i] = new Point(i,i);
            }

            for (int i = 0;i < punkte.Length; i++)
            {
                punkte[i].MovePosition(1, 1);
            }
            sw.Stop();

            Console.WriteLine("Fertig!");
            Console.WriteLine("Verstrichene Zeit: " + sw.ElapsedMilliseconds);
        }

        
    }

    struct /*class*/ Point
    {
        public int x;
        public int y;

        public Point(int _x, int _y) 
        {
            x= _x;
            y= _y;
        }

        public void MovePosition(int x_movement, int y_movement)
        {
            x += x_movement;
            y += y_movement;
        }
    }

    
}
