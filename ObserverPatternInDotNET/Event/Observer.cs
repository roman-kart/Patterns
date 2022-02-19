using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.Event
{
    class Observer
    {
        public EventHandler<SubjectEventArgs> ObserverEventHandler { get; set; } = (object sender, SubjectEventArgs args) =>
        {
            var origForeign = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Sender = {sender.ToString()}, Message = {args.Message}, Something  = {args.Something}");
            Console.ForegroundColor = origForeign;
        };
    }
}
