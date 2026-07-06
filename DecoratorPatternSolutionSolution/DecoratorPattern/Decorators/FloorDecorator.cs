using DecoratorPattern.Abstracts;

public class FloorDecorator : AbstractDecorator
{
    public FloorDecorator(AbstractHome home) : base(home)
        => this.AdditionalPrice = 2500;

    public override void MakeHome()
    {
        Console.WriteLine("waiting for creation for adding floors...");
        base.MakeHome();
        MakeFloor();
    }

    public void MakeFloor()
        => Console.WriteLine($"added floors.");
}
