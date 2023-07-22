using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator_abstr
{
    internal class Rectangle : Shape
    {
        public Rectangle(double sideA, double sideB)
        {
            Sides = new double[] { sideA, sideB };
        }
        public override double Area_calc()
        {
            return Sides[0]*Sides[1];
        }
    }
}
