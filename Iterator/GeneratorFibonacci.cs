using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class GeneratorFibonacci
    {
        /// <summary>
        /// Бесконечный генератор чисел Фибоначчи
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> GenerateFibonacci()
        {
            int prev = 0;
            int current = 1;
            yield return prev;
            while (true)
            {
                yield return current;
                int tmp = current;
                current = current + prev;
                prev = tmp;
            }
        }
    }
}
