using Lab4New_2_;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car();
        Console.WriteLine(car1);

        Car car2 = new Car("Патрол");
        Console.WriteLine(car2);

        Car car3 = new Car("Дракон", "Волговский", 2);
        Console.WriteLine(car3);

        Car car4 = new Car("Мазурик", "ЮСГ V-16", 3);
        Console.WriteLine(car4);

        Box box1 = new Box();
        Console.WriteLine(box1);

        Box box2 = new Box("УТО", 1, 2, 3, 4);
        Console.WriteLine(box2);

        Console.WriteLine($"Автомобиль {car1.Name} запрашивает заезд в гараж {box2.Name}");
        Console.WriteLine(car1.LandingRequest(box2));
        Console.WriteLine(car1);
        Console.WriteLine(box2);
        Console.WriteLine();

        Console.WriteLine($"Автомобиль {car2.Name} запрашивает заезд в гараж {box2.Name}");
        Console.WriteLine(car2.LandingRequest(box2));
        Console.WriteLine(car2);
        Console.WriteLine(box2);
        Console.WriteLine();

        Console.WriteLine($"Автомобиль {car1.Name} запрашивает заезд в гараж {box2.Name}");
        Console.WriteLine(car1.LandingRequest(box2));
        Console.WriteLine(car2);
        Console.WriteLine(box2);
        Console.WriteLine();

        Console.WriteLine($"Автомобиль {car3.Name} запрашивает заезд в гараж {box2.Name}");
        Console.WriteLine(car3.LandingRequest(box2));
        Console.WriteLine(car3);
        Console.WriteLine(box2);
        Console.WriteLine();

        Console.WriteLine($"Автомобиль {car4.Name} запрашивает заезд в гараж {box2.Name}");
        Console.WriteLine(car4.LandingRequest(box2));
        Console.WriteLine(car4);
        Console.WriteLine(box2);
        Console.WriteLine();

        //Driver driver1 = new Driver();
        //Console.WriteLine(driver1);
        //driver1.IslockCar(car1);
        //Console.WriteLine(driver1);

        Console.ReadKey();
    }
}