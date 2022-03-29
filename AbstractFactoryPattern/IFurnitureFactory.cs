namespace AbstractFactoryPattern;

// Abstract Factory
public interface IFurnitureFactory
{
    IChair GetChair();
    ISofa GetSofa();
}