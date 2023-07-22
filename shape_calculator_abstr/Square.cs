using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator_abstr
{
    internal class Square : Shape
    {
        public Square(double side) 
        {
            Sides = new double[] { side };
        }

        public override double Area_calc()
        {
            return Math.Pow(Sides[0], 2);
        }
    }
}
