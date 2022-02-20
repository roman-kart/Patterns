using VisitorPattern.Visitor;
using VisitorPattern.Products;

var cereal = new Cereal() { Name = "Tasty cereal", Description = "It's really good!", Price = 100m };
var milk = new Milk() { Name = "Really good milk", Description = "This milk is really tasty!!!", Price = 70m };
var productVisitor = new ProductVisitor();
productVisitor.DoSomething(cereal);
productVisitor.DoSomething(milk);
