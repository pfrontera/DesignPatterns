using BuilderPattern.Common;

namespace BuilderPattern.BuilderWithoutDirector;

public interface IBuilderConstructor
{
    // Returning type IBuilderConstructor we can apply Method Chaining.
    IBuilderConstructor StartUpOperations(string optionalMessage = "Making a book for you");
    IBuilderConstructor BuildBody(string optionalBodyType = "Trade paperback");
    IBuilderConstructor InsertPages(string optionalNoOfPages = "255");
    IBuilderConstructor EndOperations(string optionalEndMessage = "Book impression is completed.");
    Product ImpressBook();
}