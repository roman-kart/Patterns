using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDotNET
{
    public class ErrorMessage : IMessage
    {
        private readonly IMessage _standartMessage;
        public ErrorMessage(IMessage standartMessage)
        {
            _standartMessage = standartMessage;
        }
        public void Write(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            _standartMessage.Write(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
