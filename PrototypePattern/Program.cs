using PrototypePattern.PrototypePattern;

// Creating Concrete prototypes from an abstract class, a prototype.

var fender = new Fender("Stratocaster");
var gibson = new Gibson("Les Paul");

var guitarClone = gibson.Clone();
Console.WriteLine(gibson);
Console.WriteLine(guitarClone);

guitarClone = fender.Clone();
Console.WriteLine(fender);
Console.WriteLine(guitarClone);


// Cloning Deep, Shallow and Copy Constructor.


// Deep Copy.
var musicianOne = new Musician(1, "Anton Newcombe", new Band("The Brian Jonestown Massacre"));
var deepClonedMusician = (Musician)musicianOne.CloneDeep();
Console.WriteLine(musicianOne);
Console.WriteLine(deepClonedMusician);
deepClonedMusician.Band.Name = "L'Epee"; // This not affects to the original reference.
Console.WriteLine(musicianOne);
Console.WriteLine(deepClonedMusician);


// Shallow copy
var musicianTwo = new Musician(2, "Ace Frehley", new Band("KISS"));
var shallowClonedMusician = (Musician) musicianTwo.CloneShallow();
Console.WriteLine(musicianTwo);
Console.WriteLine(shallowClonedMusician);
shallowClonedMusician.Band.Name = "Frehley's Comet"; // This affects to the original reference.
Console.WriteLine(musicianTwo);
Console.WriteLine(shallowClonedMusician);

// Using a copy constructor.
var employee = new Employee( "Anton Newcombe", "The Brian Jonestown Massacre");
var employeeCopy = new Employee(employee);
Console.WriteLine(employee);
Console.WriteLine(employeeCopy);