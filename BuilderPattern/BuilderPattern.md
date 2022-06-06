# Builder Pattern (aka : Constructor)

**GoF Definition**:
Separate the constructor of a complex object from its representation so that the same construction process can create different representations.

In other words, is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different
types and representations of an object using the same construction code.

**Implementation steps** :

    1. Define an interface (IBuilder) for creating an object, which encapsulates all the information needed to create a new object.
    2. Define a builder class (concrete builder) that creates the object.
    3. Define a director class that creates an object using the builder class.
    4. The client code creates a builder object and then calls the builder's methods to set the parts of the object.

*Use an abstract class or an interface*
If you want centralized or default behaviors, you can use an abstract class. In those cases, you can provide some default implementation.
On the other hand, the interface implementation starts from the scratch and indicates rules/contracts for the object.

When you have multiple versions of components use an abstract class. Once you update the base class, all derived classes are updated automatically.
The inferface implementation is not updated automatically, so should not be changed once created, but we can make use of the Default interface methods
 
<br> 

**Method chaining:** 

If our IBuilder interface methods returns as their return type the IBuilder, we achieve the method chaining.
 
<br>

**Promote immutability** 

If our product class is sealed, once constructed, it cannot be modified. They can be safely shared and they are thread-safe.

<br>

**When we should consider using Builder pattern?** 

If you need to make a complex object and needs to be immutable. 

<br> 


**Advantages:**
* The director can retieve the final product from the builder when the whole construction process is completed.
* Using this pattern, the same construction process can create different representations of an object.

**Drawbacks:**
* It is not suitable if you want to deal with mutable objects.
* To create different representations of an object, you need to create different builders.