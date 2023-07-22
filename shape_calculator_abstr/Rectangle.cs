namespace shape_calculator_abstr
{
    internal class Rectangle : Shape
    {
        public Rectangle(double sideA, double sideB)
        {
            if (sideA > 0 && sideB > 0)
                Sides = new double[] { sideA, sideB };
            else throw new Exception("Стороны должны быть больше 0!");
        }
        public override double Area_calc()
        {
            return Sides[0] * Sides[1];
        }
    }
}
