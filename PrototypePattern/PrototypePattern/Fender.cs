namespace PrototypePattern.PrototypePattern
{
    public class Fender : Guitar
    {
        public Fender(string model)
        {
            ModelName = model;
            BasePrice = 7000;
        }

        public override Guitar Clone() =>
            this.MemberwiseClone() as Fender;
    }
}