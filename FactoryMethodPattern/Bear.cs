namespace FactoryMethodPattern
{
    public class Bear : IAnimal
    {
        public void AboutMe()
        {
            Console.WriteLine("I wasn't going to eat it, I was just going to taste it.");
        }
    }
}