using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDotNET
{
    public class StandartMessage : IMessage
    {
        public void Write(string message)
        {
            Console.WriteLine($"Message for user: ");
            Console.WriteLine(message);
            Console.WriteLine($"Current date and time: {DateTime.Now}");
            Console.WriteLine("----------------------");
        }
    }
}
