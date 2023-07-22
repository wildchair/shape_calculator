namespace shape_calculator
{
    internal class Rectangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
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
