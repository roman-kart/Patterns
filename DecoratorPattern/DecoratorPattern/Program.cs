using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<IMessage>()
            {
                new ErrorDecorator(new AlertMessage("Oh no, something's wrong!")),
                new ErrorDecorator(new SimpleMessage("Something's wrong, but it isn't dangerous")),
                new NormalDecorator(new AlertMessage("I have a piece of advice for you...")),
                new NormalDecorator(new SimpleMessage("Everything is fine!"))
            };
            foreach (var message in messages)
            {
                message.PrintMessage();
            }
        }
    }
}
