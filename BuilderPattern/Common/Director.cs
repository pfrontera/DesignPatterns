using BuilderPattern.AbstractBuilderWithDirector;
using BuilderPattern.BuilderWithDirector;

namespace BuilderPattern.Common;

public class Director
{
    private IBuilder _ibuilder;
    private Builder _builder;

    
    // Method Using Interface.
    public void Construct(IBuilder builder)
    {
        _ibuilder = builder;
        builder.StartUpOperations();
        builder.BuildBody();
        builder.InsertWheels();
        builder.AddHeadLights();
        builder.EndOperations();
    }
    
    // Method for using an Abstract class.
    public void Construct(Builder builder)
    {
        _builder = builder;
        builder.StartUpOperations();
        builder.BuildBody();
        builder.InsertStrings();
        builder.EndOperations();
    }
}