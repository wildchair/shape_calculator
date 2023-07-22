using shape_calculator_abstr;

Square square = new(3);
Rectangle rectangle = new(1, 2);
Triangle triangle = new(3, 1, 3);

List<Shape> shapes = new List<Shape>() { square, rectangle, triangle };
foreach (Shape shape in shapes)
    Console.WriteLine($"P={shape.Perimeter_calc()}, S={shape.Area_calc()}");