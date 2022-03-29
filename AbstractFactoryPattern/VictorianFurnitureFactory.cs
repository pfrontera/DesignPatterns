namespace AbstractFactoryPattern;

// Concrete Factory
public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair GetChair()
    {
        return new VictorianChair();
    }

    public ISofa GetSofa()
    {
        return new VictorianSofa();
    }
}
