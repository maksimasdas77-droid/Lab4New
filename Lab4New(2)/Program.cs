using Lab4New_2_;

internal class Program
{
    private static void Main(string[] args)
    {
        Engine engine1 = new Engine();
        Engine engine2 = new Engine("CR1245");
        Engine engine3 = new Engine("CR1111");
        Engine engine4 = new Engine("CR2222");
        Engine engine5 = new Engine("C33333");
        Car car1 = new Car();
        Car car2 = new Car("Тойота", engine1, 3);
        Car car3 = new Car("Лексус", engine5, 2);
        Console.WriteLine(engine1);
        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);


        Console.ReadKey();
    }
}