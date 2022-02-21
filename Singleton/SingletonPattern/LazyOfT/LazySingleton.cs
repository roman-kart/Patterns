using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.LazyOfT
{
    /// <summary>
    /// Реализация паттерна Singleton на основе Lazy of T.
    /// <para>
    /// Достоинства: 
    ///     <list type="bullet">
    ///         <item>
    ///             простота + потокобезопасность + "ленивость".
    ///         </item>    
    ///     </list>
    /// </para>
    /// <para>
    /// Недостатки:
    ///     <list type="bullet">
    ///         <item>
    ///             доступна только в .NET 4.0+ (в настоящее время не настолько критично).
    ///         </item>     
    ///     </list>
    /// </para>
    /// </summary>
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
        LazySingleton() { }
        public static LazySingleton Instance { get { return _instance.Value; } }
    }
}
