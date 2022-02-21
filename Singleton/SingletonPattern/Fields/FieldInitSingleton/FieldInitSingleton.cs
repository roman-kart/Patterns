using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Fields.FieldInitSingleton
{
    /// <summary>
    ///     <para>
    ///         Реализация Sigleton на основе статического поля.
    ///     </para>
    ///     <para>
    ///         В данном классе необходимо добавить явный статический конструктор, 
    ///         чтобы компилятор не помечал этот тип как beforefieldinit,
    ///         что в свою очередь означает,
    ///         что инициализация произойдет именно в момент обращения.
    ///     </para>
    /// </summary>
    public sealed class FieldInitSingleton
    {
        private static readonly FieldInitSingleton _instance = new FieldInitSingleton();
        FieldInitSingleton() { }
        static FieldInitSingleton() { }
        public static FieldInitSingleton Instance { get { return _instance; } }
    }
}
