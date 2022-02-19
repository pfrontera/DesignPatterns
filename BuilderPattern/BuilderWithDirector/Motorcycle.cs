using BuilderPattern.Common;

namespace BuilderPattern.BuilderWithDirector;

public class Motorcycle : IBuilder
{
    private const string LineSeparator = "**********";
    
    private string _brandName;
    
    private Product _product;

    public Motorcycle(string brand)
    {
        _product = new Product();
        _brandName = brand;
    }
    
    public void StartUpOperations()
    {
        _product.Add(LineSeparator);
        _product.Add($"Motorcycle model name : {_brandName}");
    }

    public void BuildBody() => _product.Add("This is a body of a Motorcycle");

    public void InsertWheels() => _product.Add("2 wheels are added");

    public void AddHeadLights() => _product.Add("1 Headlights are added");

    public void EndOperations() => _product.Add(LineSeparator);

    public Product GetVehicle() => _product;
}