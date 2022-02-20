using System;

namespace ObserverPatternInDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            // callback
            Console.WriteLine("Observer Callback. Start.");
            var observerCallback = new ObserverPatternInDotNET.Callback.Observer();
            var subjectCallback = new ObserverPatternInDotNET.Callback.Subject(10, observerCallback.OnSomethingUpdatedInSubject);
            for (int i = 0; i < 100; i++)
            {
                subjectCallback.Something += i * 5;
            }
            Console.WriteLine("Observer Callback. Stop.");

            WriteOutputSeparator();

            // event
            Console.WriteLine("Observer Event. Start.");
            var observerEvent = new ObserverPatternInDotNET.Event.Observer();
            var subjectEvent = new ObserverPatternInDotNET.Event.Subject(10);
            subjectEvent.OnUpdateSomething += observerEvent.ObserverEventHandler;
            for (int i = 0; i < 100; i++)
            {
                subjectEvent.Something += i * 5;
            }
            Console.WriteLine("Observer Event. Stop.");

            WriteOutputSeparator();

            // IObservable<T> IObserver<T>
            Console.WriteLine("Observer IObservable<T> and IObserver<T>. Start.");
            var subject = new ObserverPatternInDotNET.IObservable.Subject();
            var observer1 = new ObserverPatternInDotNET.IObservable.Observer("Ivanov Ivan");
            var observer2 = new ObserverPatternInDotNET.IObservable.Observer("Valeriy Albertovich");
            observer1.Subscribe(subject);
            observer2.Subscribe(subject);
            for (int i = 0; i < 10; i++)
            {
                subject.AddNewProduct(new ObserverPatternInDotNET.IObservable.NewProduct($"Product{i}", $"Product{i} is good!", 100 + i));
                if (i == 5)
                {
                    observer1.Unsubscribe(); // прекращает следить за объектом
                }
            }
            subject.AddNewProduct(null); // генерируем ошибку
            subject.EndTransfer();
            Console.WriteLine("Observer IObservable<T> and IObserver<T>. Stop.");
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
