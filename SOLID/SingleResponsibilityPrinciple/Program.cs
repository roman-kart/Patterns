using SingleResponsibilityPrinciple;

Console.WriteLine("Bad product: ");
BadProduct BadProduct = new BadProduct() { Name = "Apple", Description = "2123qweawedasd", Price = 98};
BadProduct.AddProduct();
Console.WriteLine(BadProduct.IsProductInDatabase());
BadProduct.RemoveProduct();
Console.WriteLine(BadProduct.IsProductInDatabase());

Console.WriteLine();
Console.WriteLine("Bad product: ");
IGoodProduct GoodProduct = new GoodProduct() { Name = "Apple Juice", Description = "wdaxadqwd", Price = 100 };
WorkWithGoodProduct.AddProduct(GoodProduct);
Console.WriteLine(WorkWithGoodProduct.IsProductInDatabase(GoodProduct));
WorkWithGoodProduct.RemoveProduct(GoodProduct);
Console.WriteLine(WorkWithGoodProduct.IsProductInDatabase(GoodProduct));
