using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.UserInterface;

namespace StrategyPattern.Library
{
    /// <summary>
    /// Содержит методы для взаимодействия с пользователем через консоль.
    /// Реализует интерфейс IUserInterface.
    /// В данном примере является конкретной релизацией стратегии.
    /// </summary>
    public class ConsoleInterface : IUserInterface
    {
        public string ReadMessage()
        {
            return Console.ReadLine();
        }

        public void WriteError(string message)
        {
            var originalForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = originalForeground;
        }

        public void WriteMessage(string message)
        {
            var originalForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = originalForeground;
        }

        public void WriteWarning(string message)
        {
            var originalForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = originalForeground;
        }
    }
}
