namespace shape_calculator_abstr
{
    internal class Square : Shape
    {
        public Square(double side)
        {
            if (side > 0)
                Sides = new double[] { side, side, side, side };
            else throw new Exception("Сторона должна быть больше 0!");
        }

        public override double Area_calc()
        {
            return Math.Pow(Sides[0], 2);
        }
    }
}
