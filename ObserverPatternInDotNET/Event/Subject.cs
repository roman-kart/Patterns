using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.Event
{
    class SubjectEventArgs : EventArgs
    {
        public string Message { get; internal set; }
        public decimal Something { get; internal set; }
    }
    class Subject
    {
        /// <summary>
        /// Переменная, в которой содержится значение типа decimal.
        /// </summary>
        private decimal _something;
        /// <summary>
        /// Свойство, которое предоставляет методы для управления данного св-ва.
        /// Если при изменении значения, новое значение не отличается от старого - значение не изменяется.
        /// </summary>
        public decimal Something
        {
            get
            {
                return _something;
            }
            set
            {
                // если значение отличается от существующего
                if (value != _something)
                {
                    _something = value;
                    // вызываем событие при обновлении свойства, если ему присвоено значение
                    if (this.OnUpdateSomething != null)
                    {
                        OnUpdateSomething(
                            this,
                            new SubjectEventArgs() { Message = $"New value = {_something}", Something = _something }
                        );
                    }
                }
            }
        }
        /// <summary>
        /// Метод, вызываемый при обновлении значения свойства Something
        /// </summary>
        public event EventHandler<SubjectEventArgs> OnUpdateSomething;
        public Subject(decimal initialSomething)
        {
            this._something = initialSomething;
        }
    }
}
