using BuilderPattern.Common;

namespace BuilderPattern.AbstractBuilderWithDirector;

public abstract class Builder
{
    private const string LineSeparator = "----------";
    
    public string _brandName;
    
    public Product _product;
    
    public void StartUpOperations()
    {
        _product.Add(LineSeparator);
        _product.Add($"Instrument model name : {_brandName}");
    }

    public abstract void BuildBody();

    public abstract void InsertStrings();

    public void EndOperations() => _product.Add(LineSeparator);

    public Product GetInstrument() => _product;
}