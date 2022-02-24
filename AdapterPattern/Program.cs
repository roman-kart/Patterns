using AdapterPattern;
using AdapterPattern.Products;
using AdapterPattern.ClassicAdapter;

ProductSqlServer ProductSqlServer = new ProductSqlServer("Apple", "sdfdsf", 89, 10, 5, 3);
ProductMongoDB ProductMongoDB = new ProductMongoDB(
    new ProductMongoDB.About() { Name = "Milk", Description = "sdfweqrwer", Price = 70 },
    new ProductMongoDB.Composition() { Carbohydrates = 10, Fats = 3, Proteins = 4 }
);

// classical
Console.WriteLine();
Console.WriteLine("Classical: ");
Console.WriteLine();

ProductSqlServerAdapter ProductSqlServerAdapter = new ProductSqlServerAdapter(ProductSqlServer);
ProductMongoDBAdapter ProductMongoDBAdapter = new ProductMongoDBAdapter(ProductMongoDB);

Console.WriteLine("Sql server: ");
WorkWithProduct.ShowProduct(ProductSqlServerAdapter);

Console.WriteLine();

Console.WriteLine("MongoDB: ");
WorkWithProduct.ShowProduct(ProductMongoDBAdapter);
