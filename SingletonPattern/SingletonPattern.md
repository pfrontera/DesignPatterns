#Singleton Pattern

GoF Definition:
Ensure a class has only one instace, and provide a global point of access of it.

*Implementation steps* :

    1. Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
    2. Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field. All following calls to this method return the cached object.


## Singleton

This example lays on a Static Constructor.
In this way we take the advantage that when accessing a static 
class, the object treated in the static constructor will be 
instantiated only once.

C# initializes static data and performs a specific action only once.
In addition, a static constructor is called automatically before you 
create the first instance, or you refer to any static class member.

```c# 
//Lets supose that Singleton has the field MyVariable; 
var myVar = Singleton.MyVariable;
var totalInstances = Singleton.TotalInstances;
//Just for geting "myVar" our application will have created an instance,
//so, totalInstances will be 1. 
```

## BadSingleton

Using this approach it can be useful in a single threaded environment,
but if there are two or more threads evaluating the same code perhaps 
more instances are created than desired.

## LockedSingleton

This example makes use of locks.
Lock keyword restricts code from being executed by more than one thread at the same time.

Using **volatile** keyword indicates that this field might be modified by multiple
threads that are executing at the same time. With this modifier we ensure that
all threads will observe volatile writes performed by any other thread in the
order in which they were performed. This means *It ensures that the most current
value is always present in the field*.

## LazySingleton

Used for *lazy initialization*. Technique used to delay the object creation
process. The idea is create the object only when is truly required.