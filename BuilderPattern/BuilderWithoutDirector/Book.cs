using BuilderPattern.BuilderWithoutDirector;
using BuilderPattern.Common;

namespace BuilderPattern.BuilderWithoutDirector;

public class Book : IBuilderConstructor
{
    private string _title;
    private Product _product;

    public Book(string title)
    {
        _product = new Product();
        _title = title;
    }


    public IBuilderConstructor StartUpOperations(string optionalMessage = "Making a book for you")
    {
        _product.Add($"{optionalMessage} titled {_title}");
        return this;
    }

    public IBuilderConstructor BuildBody(string optionalBodyType = "Trade paperback")
    {
        _product.Add((optionalBodyType));
        return this;
    }

    public IBuilderConstructor InsertPages(string optionalNoOfPages = "255")
    {
        _product.Add(optionalNoOfPages);
        return this;
    }

    public IBuilderConstructor EndOperations(string optionalEndMessage = "Book impression is completed.")
    {
        _product.Add(optionalEndMessage);
        return this;
    }

    public Product ImpressBook()
    {
        return _product;
    }
}