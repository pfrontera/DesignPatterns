namespace FactoryMethodPattern
{
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() =>
            new Tiger();
    }
}