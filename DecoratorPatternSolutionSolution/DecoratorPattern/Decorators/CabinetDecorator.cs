using DecoratorPattern.Abstracts;

namespace DecoratorPattern.Decorators;

public class CabinetDecorator : AbstractDecorator
{
    public CabinetDecorator(AbstractHome home) : base(home)
        => this.AdditionalPrice = 4000;

    public override void MakeHome()
    {
        Console.WriteLine("waiting for creation for  adding cabinets...");
        base.MakeHome();
        Cabinet();
    }

    public void Cabinet()
        => Console.WriteLine("added cabinets");
}
