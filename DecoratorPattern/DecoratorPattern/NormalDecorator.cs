using System;
namespace DecoratorPattern
{
    class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(Message message) : base(message)
        {

        }
        public override void PrintMessage()
        {
            var originalForeground = Console.ForegroundColor; // первоначальный цвет текста в консоли
            Console.ForegroundColor = ConsoleColor.Green;
            this._message.PrintMessage();
            Console.ForegroundColor = originalForeground;
        }
    }
}
