using DecoratorPattern.Abstracts;
using DecoratorPattern.Decorators;

public class Program
{
    public static void Main()
    {
        AbstractHome home = new ConcreteHome();
        home = new FloorDecorator(home);
        home.MakeHome();

        Console.WriteLine(new string('-', 30));

        home = new PaintDecorator(home);
        home.MakeHome();

        home = new CabinetDecorator(home);
        home.MakeHome();
    }
}