using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.DoubleCheckedLocked
{
    /// <summary>
    /// Реализация паттерна Singleton на основе Lazy of T.
    /// <para>
    /// Достоинства: 
    /// <list type="bullet">
    ///     <item>
    ///         потокобезопасность + "ленивость",
    ///     </item>
    ///     <item>
    ///        распространенность решения,     
    ///     </item>
    ///     <item>
    ///        доступна под любой версией .NET Framework.     
    ///     </item>
    /// </list>
    /// </para>
    /// <para>
    /// Недостатки:
    ///     <list type="bullet">
    ///         <item>
    ///             сложность + потенциальная хрупкость,
    ///         </item>
    ///         <item>
    ///             большой объем кода.
    ///         </item>
    ///     </list>
    /// </para>
    /// </summary>
    public sealed class DoubleCheckedLock
    {
        private static volatile DoubleCheckedLock _instance; // volatile, чтобы не изменялся порядок операция при выполнении программы
        private static readonly object _syncRoot = new object();
        DoubleCheckedLock() { }
        public static DoubleCheckedLock Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLock();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
