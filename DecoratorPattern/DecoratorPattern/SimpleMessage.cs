using System;
namespace DecoratorPattern
{
    public class SimpleMessage : Message
    {
        public SimpleMessage(string text) : base(text)
        {

        }
        public override void PrintMessage()
        {
            Console.WriteLine(this._text);
        }
    }
}
