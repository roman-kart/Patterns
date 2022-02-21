using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Fields.FieldBasedSingleton
{
    /// <summary>
    /// Реализация Singleton при помощи readonly field.
    /// </summary>
    class FieldBasedSingleton
    {
        public static readonly FieldBasedSingleton Instance =
            new FieldBasedSingleton();
    }
}
