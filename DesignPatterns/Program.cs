using DesignPatterns.SingletonPattern;

// Singleton 
GenerateInstances<Singleton>();

// Locked Singleton
GenerateInstances<LockedSingleton>();

// Bad Singleton
GenerateInstances<BadSingleton>();

// Lazy Singleton
GenerateInstances<LazySingleton>();

Console.WriteLine($"Singleton Instances = {Singleton.TotalInstances}");
Console.WriteLine($"LockedSingleton Instances = {LockedSingleton.TotalInstances}");
Console.WriteLine($"BadSingleton Instances = {BadSingleton.TotalInstances}");
Console.WriteLine($"LazySingleton Instances = {LazySingleton.TotalInstances}");

void GenerateInstances<T>()
{
    for (var i = 0; i < 100; i++)
    {
        new Thread(new ParameterizedThreadStart(CreateSingleton)).Start(typeof(T));
    }
    
    void CreateSingleton(object? o)
    {
        var type = Type.GetType(o.ToString());
        var property = type.GetProperty("GetInstance");
        property.GetValue(null);
    }
}