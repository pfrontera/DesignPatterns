namespace PrototypePattern.PrototypePattern
{
    public class Gibson : Guitar
    {
        public Gibson(string model)
        {
            ModelName = model;
            BasePrice = 10000;
        }

        public override Guitar Clone() =>
            this.MemberwiseClone() as Gibson;
    }
}