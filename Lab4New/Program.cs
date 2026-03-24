using Lab4New;

internal class Program
{
    private static void Main(string[] args)
    {
        Plane plane1 = new Plane();
        Console.WriteLine(plane1);

        Plane plane2 = new Plane("B001");
        Console.WriteLine(plane2);

        Plane plane3 = new Plane("F015");
        Console.WriteLine(plane3);

        Plane plane4 = new Plane("D188");
        Console.WriteLine(plane4);

        Airport airport1 = new Airport();
        Console.WriteLine(airport1);

        Airport airport2 = new Airport("Heathrow", "East", "West", "South");
        Console.WriteLine(airport2);
        Console.WriteLine();

        Console.WriteLine($"Самолет {plane1.BoardNumber} запрашивает посадку в аэропорту {airport2.Name}");
        Console.WriteLine(plane1.LandingRequest(airport2));
        Console.WriteLine(plane1);
        Console.WriteLine(airport2);
        Console.WriteLine();

        Console.WriteLine($"Самолет {plane2.BoardNumber} запрашивает посадку в аэропорту {airport2.Name}");
        Console.WriteLine(plane2.LandingRequest(airport2));
        Console.WriteLine(plane2);
        Console.WriteLine(airport2);
        Console.WriteLine();

        Console.WriteLine($"Самолет {plane1.BoardNumber} запрашивает посадку в аэропорту {airport2.Name}"); //проверка повторного запроса
        Console.WriteLine(plane1.LandingRequest(airport2));
        Console.WriteLine(plane1);
        Console.WriteLine(airport2);
        Console.WriteLine();

        Console.WriteLine($"Самолет {plane3.BoardNumber} запрашивает посадку в аэропорту {airport2.Name}");
        Console.WriteLine(plane3.LandingRequest(airport2)); //только для понимания, по факту нам не нужно это
        Console.WriteLine(plane3);
        Console.WriteLine(airport2);
        Console.WriteLine();

        Console.WriteLine($"Самолет {plane4.BoardNumber} запрашивает посадку в аэропорту {airport2.Name}");
        Console.WriteLine(plane4.LandingRequest(airport2));
        Console.WriteLine(plane4);
        Console.WriteLine(airport2);
        Console.WriteLine();




        Console.ReadKey();
    }
}