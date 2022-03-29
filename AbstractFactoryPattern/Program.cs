using AbstractFactoryPattern;

var victorianFactory = new VictorianFurnitureFactory();
var modernFactory = new ModernFurnitureFactory();

var victorianChair = victorianFactory.GetChair();
var victorianSofa = victorianFactory.GetSofa();
var modernSofa = modernFactory.GetSofa();
var modernChair = modernFactory.GetChair();

victorianChair.ShowMe();
victorianSofa.ShowMe();
modernChair.ShowMe();
modernSofa.ShowMe();