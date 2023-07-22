using System.Drawing;

namespace shape_calculator
{
    internal class Rectangle : IShape
    {
        private double sideA;
        private double sideB;

        public double SideA 
        { 
            get => sideA; 
            set
            {
                if (value > 0)
                    sideA = value;
                else throw new Exception("Сторона должна быть больше 0!");
            }
        }
        public double SideB 
        { 
            get => sideB; 
            set
            {
                if (value > 0)
                    sideB = value;
                else throw new Exception("Сторона должна быть больше 0!");
            }
        }

        public double Area_calc()
        {
            return SideA*SideB;
        }

        public double Perimeter_calc()
        {
            return (SideA + SideB) * 2;
        }
    }
}
