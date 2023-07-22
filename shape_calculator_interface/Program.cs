using shape_calculator;

Triangle triangle = new(3, 1, 3);
Square square = new() { Side = 3 };

IShape[] shapes = { triangle, square };

foreach (IShape shape in shapes)
    Console.WriteLine($"S={shape.Area_calc()} P={shape.Perimeter_calc()}");