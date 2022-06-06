using System;

namespace AbstractFactoryPattern;

public class VictorianSofa : ISofa
{
    public void ShowMe()
    {
        Console.WriteLine("I'm an exquisite Victorian sofa");
    }
}