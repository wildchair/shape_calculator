namespace shape_calculator
{
    internal class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else throw new Exception("Такого треугольника не существует!");
        }
        private double sideA;
        private double sideB;
        private double sideC;
        public double Area_calc()
        {
            double p = this.Perimeter_calc();
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public double Perimeter_calc()
        {
            return sideA + sideB + sideC;
        }
    }
}
