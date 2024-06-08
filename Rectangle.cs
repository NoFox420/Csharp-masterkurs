using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }

        public Rectangle(double width, double height)
        {
            Height = height;
            Width = width;
        }
        public override string ToString()
        {
            return "Rechteck mit einer Höhe von " + Height + " und einer Breite von " + Width + ".";
        }
    }
}
