using BuilderPattern.AbstractBuilderWithDirector;
using BuilderPattern.BuilderWithDirector;
using BuilderPattern.BuilderWithoutDirector;
using BuilderPattern.Common;

// Builder Pattern with Director using Interfaces
var director = new Director();

var car = new Car("Fiat");
director.Construct(car);
var carProduct = car.GetVehicle();
carProduct.Show();

var moto = new Motorcycle("Harley");
director.Construct(moto);
var motoProduct = moto.GetVehicle();
motoProduct.Show();


// Builder Pattern with Director using Abstract class
var gibson = new Guitar("Gibson Les Paul");
director.Construct(gibson);
var gibsonProduct = gibson.GetInstrument();
gibsonProduct.Show();

var fender = new Bass("Fender Precision Bass");
director.Construct(fender);
var fenderProduct = fender.GetInstrument();
fenderProduct.Show();

// Builder Pattern without Director using Interfaces with method chaining.
new Book("Where the wild things are")
    .StartUpOperations()
    .BuildBody()
    .InsertPages()
    .EndOperations()
    .ImpressBook().Show();


