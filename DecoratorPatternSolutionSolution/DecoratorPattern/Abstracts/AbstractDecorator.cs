using DecoratorPattern.Abstracts;

public abstract class AbstractDecorator : AbstractHome
{
    protected AbstractHome _home;
    protected AbstractDecorator(AbstractHome home)
    {
        this.AdditionalPrice = 0;
        _home = home;
    }

    public override void MakeHome()
        => _home.MakeHome();
}
