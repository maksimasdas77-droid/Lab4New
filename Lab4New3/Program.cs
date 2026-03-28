using Lab4New3;

internal class Program
{
    private static void Main(string[] args)
    {
        Shape point1 = new Point(-3.5, 23.98);
        point1.Print();

        Console.WriteLine($"Периметр точки = {point1.Perimeter()}");
        Console.WriteLine($"Площадь точки = {point1.Square()}");
        Console.WriteLine();
        
        Shape circle1 = new Circle(5.7, -1.2, 5);
        circle1.Print();
        Console.WriteLine($"Периметр окружности {circle1.Perimeter():0.00}");
        Console.WriteLine($"Площадь окружности {circle1.Square():0.00}");
        Console.WriteLine();

        Rectangle rec1 = new Rectangle(5.7, -1.2, 5, 6);
        rec1.Print();
        rec1.X = -2;
        rec1.Print();
        Console.WriteLine($"Периметр прямоугольника {rec1.Perimeter():0.00}");
        Console.WriteLine($"Площадь прямоугольника {rec1.Square():0.00}");
        Console.WriteLine();

        Console.ReadKey();
    }
}