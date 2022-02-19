using Iterator;

Console.WriteLine("Fibonacci: ");
foreach (var num in GeneratorFibonacci.GenerateFibonacci())
{
    if (num < 0)
    {
        break;
    }
    Console.WriteLine(num);
}

Console.WriteLine();
Console.WriteLine($"Files in {Environment.CurrentDirectory}:");
var dir = new CurrentDirectory();
foreach (var file in dir.FilesNames(Environment.CurrentDirectory))
{
    Console.WriteLine(file);
}