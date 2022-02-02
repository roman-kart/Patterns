using System;
namespace DecoratorPattern
{
    abstract public class Message : IMessage
    {
        protected string _text;
        public Message(string text)
        {
            this._text = text;
        }
        abstract public void PrintMessage();
    }
}
