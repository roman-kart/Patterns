using System;
namespace Observer
{
    class Observer
    {
        ConsoleColor _color;
        public Observer(ConsoleColor color)
        {
            _color = color;
        }
        internal void ObserverQuantity(int quantity)
        {
            var originalConsoleForeground = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            Console.WriteLine($"I observer the new quantity value of {quantity}");
            Console.ForegroundColor = originalConsoleForeground;
        }
    }
}
