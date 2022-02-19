using BuilderPattern.Common;

namespace BuilderPattern.BuilderWithDirector;

public class Car : IBuilder
{
    private const string LineSeparator = "----------";
    
    private string _brandName;
    
    private Product _product;

    public Car(string brand)
    {
        _product = new Product();
        _brandName = brand;
    }
    
    public void StartUpOperations()
    {
        _product.Add(LineSeparator);
        _product.Add($"Car model name : {_brandName}");
    }

    public void BuildBody() => _product.Add("This is a body of a Car");

    public void InsertWheels() => _product.Add("4 wheels are added");

    public void AddHeadLights() => _product.Add("2 Headlights are added");

    public void EndOperations() => _product.Add(LineSeparator);

    public Product GetVehicle() => _product;
}