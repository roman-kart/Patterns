using System;
namespace DecoratorPattern
{
    abstract class MessageDecorator : IMessage
    {
        protected Message _message;
        public MessageDecorator(Message message)
        {
            this._message = message;
        }
        abstract public void PrintMessage();
    }
}
