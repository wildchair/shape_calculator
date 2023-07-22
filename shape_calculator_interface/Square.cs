namespace shape_calculator
{
    internal class Square : IShape
    {
        private double side;
        public double Side 
        { 
            get => side; 
            set 
            {
                if (value > 0) 
                    side = value; 
                else throw new Exception("Сторона должна быть больше 0!");
            } 
        }
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
