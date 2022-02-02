using System;

namespace DecoratorPattern
{
    public class AlertMessage : Message
    {
        public AlertMessage(string text) : base(text)
        {

        }
        public override void PrintMessage()
        {
            Console.Write("Alert! ");
            Console.WriteLine(this._text);
        }
    }
}
