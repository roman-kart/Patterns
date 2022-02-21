using AbstractFactory.AbstractFactoryClassic;
#region Abstract Factory Classic
var provider1 = new Concrete1ProductProvider();
var provider2 = new Concrete2ProductProvider();

var client = new NeedProducts();

client.ShowAllProduct(provider1);
client.ShowAllProduct(provider2);
#endregion
