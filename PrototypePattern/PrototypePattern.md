# Prototype Pattern (aka : Clone)

**GoF Definition**:
Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

In another words, is a creational design pattern that provides an alternative method for instantiating new objects by copying or cloning an instance of an existing object. The core idea of this pattern is to 
create an object that is based on another object.


*Implementation steps* :

    1. Having a prototype interface or prototype abstract class with the method clone().
    2. The concrete class that implements the prototype interface or the concrete class that extends the prototype abstract class.
    3. The client class in this case, Program, can create a new object by calling the clone() method of the prototype object.

In the examples you can see that if the class has circular dependencies, the clone() method (known as shallow clone) will not work. In that case, you need to use do a Deep Copy.

* **Shallow Copy** : The simple type fields of a are copied to the cloned instance, but for the reference type fields, only the reference is copied.


* **Deep Copy** : The deep copy is a copy of the object, and the reference to the object is copied.

*Challenges associated with this pattern*:
* Each subclass needs to implement the cloning or copying mechanism.
* Implementing the cloning mechanism can be challenging if the objects under consideration do not support copying or if there are circular references.