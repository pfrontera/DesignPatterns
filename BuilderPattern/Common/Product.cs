namespace BuilderPattern.Common;

public sealed class Product
{
    private readonly LinkedList<string> _parts;

    public Product()
    {
        _parts = new LinkedList<string>();
    }

    public void Add(string part) => 
        _parts.AddLast(part);

    public void Show()
    {
        Console.WriteLine("\nProduct completed as below : ");
        foreach( var part in _parts)
            Console.WriteLine(part);
    }
}