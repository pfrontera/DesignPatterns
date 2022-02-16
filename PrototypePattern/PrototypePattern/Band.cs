namespace PrototypePattern.PrototypePattern
{
    public class Band
    {
        public string Name { get; set; }
        
        public Band(string name)
        {
            this.Name = name;
        }

        public object Clone() =>
            this.MemberwiseClone();

        public override string ToString() =>
            $"{this.Name}, HashCode: {this.GetHashCode()}";
    }
}