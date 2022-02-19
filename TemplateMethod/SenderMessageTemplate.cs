using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class SenderMessageTemplate
    {
        /// <summary>
        /// Шаблонный метод, который определяет порядок действий, 
        /// а дочерним классам необходимо предоставить реализацию этих шагов
        /// </summary>
        /// <param name="original"></param>
        public void Send(string original)
        {
            original = AddMetaData(original);
            SendMessage(original);
        }
        /// <summary>
        /// Метод, который используется в шаблонном методе и который необходимо переопределить дочерним классам
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected abstract string AddMetaData(string message);
        /// <summary>
        /// Метод, который используется в шаблонном методе и который необходимо переопределить дочерним классам
        /// </summary>
        /// <param name="message"></param>
        protected abstract void SendMessage(string message);
    }
}
