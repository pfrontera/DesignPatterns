using FactoryMethodPattern;

var tiger = new TigerFactory().MakeAnimal(false);
var bear = new BearFactory().MakeAnimal(true);
