namespace PrototypePattern.PrototypePattern
{
    public abstract class Guitar
    {
        public int BasePrice = 0;
        public string ModelName { get; set; }

        public abstract Guitar Clone();
        
        public override string ToString() =>
            $"Model: {this.ModelName} Price: {this.BasePrice} HashCode: {this.GetHashCode()}";
    }
}