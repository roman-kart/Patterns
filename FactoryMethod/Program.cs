using FactoryMethod;
using FactoryMethod.StaticFactoryMethod;
using FactoryMethod.ClassicFactoryMethod;
using FactoryMethod.Products;

// classical
Console.WriteLine();
Console.WriteLine("Classical: ");
var fruitFactoryMethod = new FruitFactory();
var vegetablesFactoryMethod = new VegetableFactory();

var workWithProductFruit = new WorkWithProductClassical(fruitFactoryMethod);
workWithProductFruit.AboutProduct();

var workWithProductVegetables = new WorkWithProductClassical(vegetablesFactoryMethod);
workWithProductVegetables.AboutProduct();

// static
Console.WriteLine();
Console.WriteLine("Static: ");
var staticFactoryMethod = new StaticFactoryMethod();
var workWithProductsStatic = new WorkWithProductStatic(staticFactoryMethod);
workWithProductsStatic.AboutFruit();
workWithProductsStatic.AboutVegetable();