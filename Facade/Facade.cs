using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// Паттер Fascade удобно использовать для работы со сторонними библиотеками,
    /// так как это позволит безболезненно заменить библиотеку во время разработки.
    /// </summary>
    public class Facade
    {
        public static void DoSomethingForApp()
        {
            AnyLibrary.DoSomething();
        }
        public static void DoSomething1ForApp()
        {
            AnyLibrary.DoSomething1();
        }
    }
}
