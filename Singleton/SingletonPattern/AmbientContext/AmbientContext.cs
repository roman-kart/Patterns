using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.AmbientContext
{
    public interface IAmbientContext
    {
        void DoSomething();
    }
    class DefaultAmbientContext : IAmbientContext
    {
        public void DoSomething()
        {
            Console.WriteLine("Hello, World! I'm DefaultAmbientContext");
        }
    }
    class AnotherAmbientContext : IAmbientContext
    {
        public void DoSomething()
        {
            Console.WriteLine("Hello, World! I'm AnotherAmbientContext");
        }
    }
    class GlobalAmbientContext
    {
        private static IAmbientContext _ambientContext = new DefaultAmbientContext();
        // Классы этой сборки смогут задать нужный экземпляр singleton
        public static IAmbientContext AmbientContext
        {
            get { return _ambientContext; }
            internal set { _ambientContext = value; }
        }
    }
}
