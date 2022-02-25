using OpenClosedPrinciple;
using OpenClosedPrinciple.Inheritance;
using OpenClosedPrinciple.Products;
using OpenClosedPrinciple.VisitorPattern;


// OCP: модуль должен быть полностью реализован, но изменяемым в случае необходимости
// достигнуть этого можно либо при помощи наследования (новые данные), либо при помощи паттерна Visitor (новые действия)

BaseProduct BaseProduct = new ProductMongoDB() { 
    Name = "BaseProduct", 
    Description = "Affsdfdfad", 
    Price = 100, 
    JsonData = "{SomethingBase: \"dataBase\"}"
};

ProductMongoDB ProductMongoDB = new ProductMongoDB()
{
    Name = "MongoDBProduct",
    Description = "sdadazx",
    Price = 110,
    JsonData = "{SomethingMongo: \"dataMongo\"}"
};

ProductSqlServer ProductSqlServer = new ProductSqlServer()
{
    Name = "SqlServerProduct",
    Description = "qasqsax",
    Price = 120,
    CreateDate = DateTime.Now,
    GUID = Guid.NewGuid()
};
// Inheritance
Console.WriteLine();
Console.WriteLine("Inheritance: ");
WorkWithProducts.ShowProduct(BaseProduct);
WorkWithProducts.ShowProduct(ProductMongoDB);
WorkWithProducts.ShowProduct(ProductSqlServer);


// Visitor
Console.WriteLine();
Console.WriteLine("Visitor: ");
ShowProductVisitor ShowProductVisitor = new ShowProductVisitor();
BaseProduct.Accept(ShowProductVisitor);
ProductMongoDB.Accept(ShowProductVisitor);
ProductSqlServer.Accept(ShowProductVisitor);
