namespace PrototypePattern.PrototypePattern
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Band Band { get; set; }
        
        public Musician(int id, string name, Band band)
        {
            this.Id = id;
            this.Name = name;
            this.Band = band;
        }

        public object CloneDeep()
        {
            var musician = (Musician) this.MemberwiseClone();
            musician.Band = (Band) Band.Clone();
            return musician;
        }

        public object CloneShallow() =>
            this.MemberwiseClone();

        public override string ToString() =>
            $"Musician Id: {this.Id}, Name: {this.Name}, HashCode: {this.GetHashCode()} Band: {this.Band}";
    }
}