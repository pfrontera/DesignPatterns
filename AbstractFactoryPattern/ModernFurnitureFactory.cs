namespace AbstractFactoryPattern;

// Concrete Factory
public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair GetChair()
    {
        return new ModernChair();
    }

    public ISofa GetSofa()
    {
        return new ModernSofa();
    }
}