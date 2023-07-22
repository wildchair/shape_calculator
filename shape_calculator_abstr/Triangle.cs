namespace shape_calculator_abstr
{
    internal class Triangle : Shape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
                Sides = new double[] { sideA, sideB, sideC };
            else throw new Exception("Такого треугольника не существует!");
        }

        public override double Area_calc()
        {
            double p = this.Perimeter_calc();
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }
    }
}
