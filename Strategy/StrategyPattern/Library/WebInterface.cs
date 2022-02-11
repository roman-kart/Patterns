using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.UserInterface;

namespace StrategyPattern.Library
{
    /// <summary>
    /// Содержит методы для взаимодействия с пользователем через веб-интерфейс.
    /// Реализует интерфейс IUserInterface.
    /// В данном примере является конкретной релизацией стратегии.
    /// (При попытке вызвать какой-либо метод будет сгенерировано исключение, 
    /// так как в методах отсутствует реализация).
    /// </summary>
    public class WebInterface : IUserInterface
    {
        public string ReadMessage()
        {
            throw new NotImplementedException();
        }

        public void WriteError(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void WriteWarning(string message)
        {
            throw new NotImplementedException();
        }
    }
}
