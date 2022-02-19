using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.Callback
{
    class Observer
    {
        public Action<decimal> OnSomethingUpdatedInSubject { get; init; } = (decimal val) =>
        {
            var origForeign = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"New value = {val}. Current time: {DateTime.Now}");
            Console.ForegroundColor = origForeign;
        };
    }
}
