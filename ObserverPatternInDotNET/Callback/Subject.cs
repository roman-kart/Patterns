using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternInDotNET.Callback
{
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
        public decimal Something { 
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
                    this.OnUpdateSomething(_something); // вызываем метод при обновлении свойства
                }
            } 
        }
        /// <summary>
        /// Метод, вызываемый при обновлении значения свойства Something
        /// </summary>
        public Action<decimal> OnUpdateSomething;
        public Subject(decimal initialSomething, Action<decimal> initialOnUpdateSomething)
        {
            this._something = initialSomething;
            this.OnUpdateSomething = initialOnUpdateSomething;
        }
    }
}
