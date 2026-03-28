using Lab4New4;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new JustCar();
        car1.Print();
        Console.WriteLine($"Нужно {car1.FuelNeeded()}л. что бы проехать 1000 км");
        Console.WriteLine($"Может проехать {car1.Mileage()}км на полном баке");
        Console.WriteLine();

        Truck car2 = new Truck("Грузовик", 400, 50, 10000);
        car2.Print();
        Console.WriteLine($"Нужно {car2.FuelNeeded()}л. что бы проехать 1000 км");
        Console.WriteLine($"Может проехать {car2.Mileage()}км на полном баке");
        Console.WriteLine();

        Car car3 = new Ecar("Гибрид", 40, 3, 200);
        car3.Print();
        Console.WriteLine($"Нужно {car3.FuelNeeded():0.00}л. что бы проехать 1000 км");
        Console.WriteLine($"Может проехать {car3.Mileage():0.00}км на полном баке");
    }
}