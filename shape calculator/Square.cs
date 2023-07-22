using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_calculator
{
    internal class Square : IShape
    {
        public double Side { get; set; }
        public double Area_calc()
        {
            return Math.Pow(Side, 2);
        }

        public double Perimeter_calc()
        {
            return Side * 4;
        }
    }
}
