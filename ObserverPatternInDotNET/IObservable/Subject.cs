using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.IObservable
{
    public class Subject : IObservable<NewProduct>
    {
        private List<IObserver<NewProduct>> _observers;
        public Subject()
        {
            this._observers = new List<IObserver<NewProduct>>();
        }
        public IDisposable Subscribe(IObserver<NewProduct> observer)
        {
            // если наблюдателя нет
            if (!this._observers.Contains(observer))
            {
                this._observers.Add(observer); // добавляем его в список
            }
            return new Unsubscriber(this._observers, observer); // возвращаем объект, в котором содержится логика отписки
        }
        public void AddNewProduct(NewProduct newProduct)
        {
            foreach (var observer in _observers)
            {
                if (newProduct == null)
                {
                    observer.OnError(new NewProductUnknownException());
                }
                else
                {
                    observer.OnNext(newProduct);
                }
            }
        }
        public void EndTransfer()
        {
            foreach (var observer in _observers.ToArray())
            {
                if (_observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }
            _observers.Clear();
        }
        public class Unsubscriber : IDisposable
        {
            private IObserver<NewProduct> _observer;
            private List<IObserver<NewProduct>> _observers;
            public Unsubscriber(List<IObserver<NewProduct>> observers, IObserver<NewProduct> observer)
            {
                _observers = observers;
                _observer = observer;
            }
            public void Dispose()
            {
                // если текущий объект не равен null, а также существует в массиве
                if (this._observer != null && this._observers.Contains(this._observer))
                {
                    this._observers.Remove(this._observer); // удаляем элемент из массива
                }
            }
        }
        public class NewProductUnknownException : Exception
        {
            internal NewProductUnknownException() { }
        }
    }
}
