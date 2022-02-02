using System;
namespace DecoratorPattern
{
    class ErrorDecorator : MessageDecorator
    {
        public ErrorDecorator(Message message) : base(message)
        {
        }
        public override void PrintMessage()
        {
            var originalForeground = Console.ForegroundColor; // первоначальный цвет текста в консоли
            Console.ForegroundColor = ConsoleColor.DarkRed;
            this._message.PrintMessage();
            Console.ForegroundColor = originalForeground;
        }
    }
}
