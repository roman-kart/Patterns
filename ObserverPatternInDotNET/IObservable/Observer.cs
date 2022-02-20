using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.IObservable
{
    public class Observer : IObserver<NewProduct>
    {
        private IDisposable _unsubscriber;
        private string _observerName;
        public Observer(string observerName)
        {
            this._observerName = observerName;
        }
        public void Subscribe(IObservable<NewProduct> provider)
        {
            if (provider != null)
            {
                _unsubscriber = provider.Subscribe(this);
            }
        }
        public void OnCompleted()
        {
            Console.WriteLine($"Передача новых продуктов завершена! Observer: {_observerName}");
            Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Ошибка при передаче нового продукта! Observer: {_observerName}");
        }

        public void OnNext(NewProduct value)
        {
            Console.WriteLine($"Новый продукт! NewProduct: {value.Name}, {value.Price}. Description: {value.Description}! " +
                $"Observer: {_observerName}");
        }
        public void Unsubscribe()
        {
            _unsubscriber?.Dispose();
        }
    }
}
