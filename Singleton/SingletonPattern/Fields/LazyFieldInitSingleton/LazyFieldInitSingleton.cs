using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Fields.LazyFieldInitSingleton
{
    /// <summary>
    /// Реализация Singleton при помощи вложенного класса.
    /// <para>
    /// Вложенный класс делает реализацию полностью "ленивой".
    /// Пустой статический конструктор уже не нужен, 
    /// если мы будем обращатся к полю _instance лишь из свойства Instance класса LazyFieldSingleton.
    /// </para>
    /// </summary>
    public sealed class LazyFieldInitSingleton
    {
        private LazyFieldInitSingleton() { }
        public static LazyFieldInitSingleton Instance
        {
            get { return SingletonHolder._instance; }
        }
        private static class SingletonHolder
        {
            public static readonly LazyFieldInitSingleton _instance =
                new LazyFieldInitSingleton();
        }
    }
}
