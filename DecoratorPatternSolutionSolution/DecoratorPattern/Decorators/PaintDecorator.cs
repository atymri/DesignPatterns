using DecoratorPattern.Abstracts;

public class PaintDecorator : AbstractDecorator
{
    public PaintDecorator(AbstractHome home) : base(home)
        => this.AdditionalPrice = 3300;

    public override void MakeHome()
    {
        Console.WriteLine("waiting for creation for painting the house...");
        base.MakeHome();
        Paint();
    }

    public void Paint()
        => Console.WriteLine("painted the house.");
}
