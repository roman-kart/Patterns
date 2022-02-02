using System;
namespace Observer
{
    class Subject
    {
        public delegate void QuantityUpdated(int value);
        public event QuantityUpdated OnQuantityUpdated;

        private int _quantity = 0;
        public void UpdateQuantity(int value)
        {
            this._quantity += value;

            // оповещение наблюдателей
            // Invoke вызывает выполнение всех методов, подписанных на событие
            OnQuantityUpdated?.Invoke(_quantity);
        }
    }
}
