using Builder.ClassicalBuilder;
using Builder.Products;
using Builder.ConditionBuilder;

// classical builder

var productClassic = new ClassicalProductBuilder()
    .SetName("Orange")
    .SetDescription("Tasty")
    .SetPrice(90)
    .Build();

Console.WriteLine("Classical Builder: ");
Console.WriteLine($"{productClassic.Name} - {productClassic.Price} ({productClassic.Description})");
Console.WriteLine();

// condition builder

var productCondition = new ConditionBuilder()
    .AddDescription("dfsdfsdfsdf")
    .AddName("Apple juice")
    .AddPrice(70)
    .Build();

Console.WriteLine("Condition Builder: ");
Console.WriteLine($"{productCondition.Name} - {productCondition.Price} ({productCondition.Description})");
Console.WriteLine();
