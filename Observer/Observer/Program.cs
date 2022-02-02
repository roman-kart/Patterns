using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var obs1 = new Observer(ConsoleColor.DarkGreen);
            var obs2 = new Observer(ConsoleColor.DarkYellow);
            var obs3 = new Observer(ConsoleColor.Magenta);
            var obs4 = new Observer(ConsoleColor.DarkGray);

            var subject = new Subject();
            subject.OnQuantityUpdated += obs1.ObserverQuantity;
            subject.OnQuantityUpdated += obs2.ObserverQuantity;
            subject.OnQuantityUpdated += obs3.ObserverQuantity;
            subject.OnQuantityUpdated += obs4.ObserverQuantity;

            subject.UpdateQuantity(-909);
            subject.UpdateQuantity(101);
        }
    }
}
