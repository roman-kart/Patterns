using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDotNET
{
    public class SuccessMessage : IMessage
    {
        private readonly IMessage _standartMessage;
        public SuccessMessage(IMessage standartMessage)
        {
            _standartMessage = standartMessage;
        }
        public void Write(string message)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            _standartMessage.Write(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
