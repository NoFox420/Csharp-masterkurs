using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
