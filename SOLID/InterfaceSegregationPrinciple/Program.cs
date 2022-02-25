Product Product = new Product() { Name = "Apple", Description = "dsfsdfdsf", Price = 100 };
CompositProduct CompositProduct = new CompositProduct() { 
    Name = "Apple juice", 
    Description = "sqwsacdzcz", 
    Price = 100,
    Products = new List<Product> { Product }
};


// Bad
WorkWithProducts.ShowProduct(Product);
WorkWithProducts.ShowComposiitonProduct(CompositProduct);
WorkWithProducts.AddProduct(Product);
WorkWithProducts.AddProduct(CompositProduct);

// Good
ShowProducts.Do(Product);
ShowProducts.Do(CompositProduct);
ProductDB.Add(Product);
ProductDB.Add(CompositProduct);
