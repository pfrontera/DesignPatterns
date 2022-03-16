namespace FactoryMethodPattern
{
    public class BearFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() =>
            new Bear();
    }
}