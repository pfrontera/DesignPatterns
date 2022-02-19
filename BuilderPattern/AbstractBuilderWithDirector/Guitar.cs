using BuilderPattern.Common;

namespace BuilderPattern.AbstractBuilderWithDirector;

public class Guitar : Builder
{

    public Guitar(string brand)
    {
        _product = new Product();
        _brandName = brand;
    }

    public override void BuildBody() => _product.Add("This is a body of a guitar");
    public override void InsertStrings() => _product.Add("6 strings are added");

}