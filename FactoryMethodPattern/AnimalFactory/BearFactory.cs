namespace FactoryMethodPattern.AnimalFactory
{
    public class BearFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() =>
            new Bear();
    }
}