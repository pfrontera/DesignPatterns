using BuilderPattern.Common;

namespace BuilderPattern.AbstractBuilderWithDirector;

public class Bass : Builder
{
    public Bass(string brand)
    {
        _product = new Product();
        _brandName = brand;
    }
    
    public override void BuildBody() => _product.Add("This is a body of a Bass");

    public override void InsertStrings() => _product.Add("4 strings are added");
}