using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.UserInterface
{
    /// <summary>
    /// Содержит методы для взаимодействия с пользователем при помощи
    /// определенного интерфейса.
    /// В данном примере является стратегией, так как определяет интерфейс алгоритмов.
    /// </summary>
    public interface IUserInterface
    {
        public void WriteMessage(string message);
        public void WriteError(string message);
        public void WriteWarning(string message);
        public string ReadMessage();
    }
}
