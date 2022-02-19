using System;

namespace ObserverPatternInDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer Callback. Start.");
            var observerCallback = new ObserverPatternInDotNET.Callback.Observer();
            var subjectCallback = new ObserverPatternInDotNET.Callback.Subject(10, observerCallback.OnSomethingUpdatedInSubject);
            for (int i = 0; i < 100; i++)
            {
                subjectCallback.Something += i * 5;
            }
            Console.WriteLine("Observer Callback. Stop.");

            WriteOutputSeparator();

            Console.WriteLine("Observer Event. Start.");
            var observerEvent = new ObserverPatternInDotNET.Event.Observer();
            var subjectEvent = new ObserverPatternInDotNET.Event.Subject(10);
            subjectEvent.OnUpdateSomething += observerEvent.ObserverEventHandler;
            for (int i = 0; i < 100; i++)
            {
                subjectEvent.Something += i * 5;
            }
            Console.WriteLine("Observer Event. Stop.");
        }
        static void WriteOutputSeparator()
        {
            int countOfSeparators = 3;
            for (int i = 0; i < countOfSeparators; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
