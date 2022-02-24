using CompositePattern;
using CompositePattern.ConcreteComposite;

List<IProduct> products = new List<IProduct>()
{
    new Product(){Name = "Apple", Description = "qwqrq", Price = 70},
    new Product(){Name = "Apple Juice", Description = "qwqtw", Price = 80}
};


ICompositeProduct CompositeProduct = new CompositeProduct() { Name = "Chocolate box", Description = "box of sweets", Price = 300};
CompositeProduct.Add(new Product() { Name = "Candy", Description = "safqqr", Price = 0 });
CompositeProduct.Add(new Product() { Name = "Chocolate bar", Description = "zxczxczxc", Price = 0 });
CompositeProduct.Add(new Product() { Name = "Marmalade", Description = "qaazqqa", Price = 0 });
List<ICompositeProduct> compositeProducts = new List<ICompositeProduct>() { CompositeProduct};

List<IProduct> mixedProducts = new List<IProduct>();
mixedProducts.AddRange(products);
mixedProducts.AddRange(compositeProducts);

Console.WriteLine("Standart products: ");
WorkWithProducts.ShowProducts(mixedProducts);
Console.WriteLine();
Console.WriteLine("Composite products");
Console.WriteLine();
WorkWithCompositeProducts.ShowProducts(compositeProducts);