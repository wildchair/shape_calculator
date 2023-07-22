using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator_abstr
{
    internal abstract class Shape
    {
        protected double[] Sides { get; set; }
        public double Perimeter_calc()
        {
            double p = 0;
            foreach (var side in Sides)
            {
                p += side;
            }
            return p;
        }
        public abstract double Area_calc();
    }
}
