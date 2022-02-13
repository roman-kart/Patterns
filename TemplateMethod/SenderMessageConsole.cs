using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class SenderMessageConsole : SenderMessageTemplate
    {
        /// <summary>
        /// Дочерний класс предоставляет реализацию для данного шага алгоритма
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected override string AddMetaData(string message)
        {
            message = $"Path: {Environment.CurrentDirectory}\n" +
                $"OS: {Environment.OSVersion}\n" +
                $"Machine name: {Environment.MachineName}\n" + message;
            return message;
        }
        /// <summary>
        /// Дочерний класс предоставляет реализацию для данного шага алгоритма
        /// </summary>
        /// <param name="message"></param>
        protected override void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
