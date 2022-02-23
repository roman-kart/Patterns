using System.Threading;

while (true)
{
    Thread.Sleep(100);
    var key = Console.ReadKey();
    Console.WriteLine(key.Key);
}