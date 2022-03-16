namespace FactoryMethodPattern
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();

        public IAnimal MakeAnimal(bool printAboutMe)
        {
            var animal = CreateAnimal();
            if (printAboutMe)
            {
                animal.AboutMe();
            }
            return animal;
        }
    }
}