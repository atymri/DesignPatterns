using DecoratorPattern.Abstracts;

public class ConcreteHome : AbstractHome
{
    public ConcreteHome()
    {
        this.AdditionalPrice = 0;
    }
    public override void MakeHome()
        => Console.WriteLine($"Making home in {nameof(ConcreteHome)}.{MakeHome}");

    public override string ToString()
    {
        return $"price: {AdditionalPrice}";
    }
}
