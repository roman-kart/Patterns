using LiskovSubstitutionPrinciple;
using LiskovSubstitutionPrinciple.Bad;
using LiskovSubstitutionPrinciple.Good;

//Должна существовать возможность использовать объекты производного класса вместо объектов базового класса.
//Это значит, что объекты производного класса должны вести себя согласованно, согласно контракту базового класса

BadProductChildren BadProductChildren = new BadProductChildren() { 
    Name = "BadApple", 
    Description = "Qwedscfz", 
    DiscountPercent = 10, 
    Price = 100 
};

GoodProductChildren GoodProductChildren = new GoodProductChildren() { 
    Name = "GoodAple", 
    Price = 100, 
    DiscountPercent = 10, 
    Description = "dfsdf", 
    FixedDiscount = 10 
};

WorkWithProducts.ShowPorduct(BadProductChildren);
WorkWithProducts.ShowPorduct(GoodProductChildren);
