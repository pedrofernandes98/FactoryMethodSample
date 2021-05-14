using FactoryMethodSample.Products.Interfaces;
using System;

namespace FactoryMethodSample
{
    public abstract class LogManager
    {
        public string FormatLog(string type, string message)
        {
            return $"[{DateTime.Now}][{type}] - {message}";
        }

        public void Log(string type, string message)
        {
            string messageFormat = FormatLog(type, message);
            ILogWriter logWriter = createLogWriter();
            logWriter.WriteLog(messageFormat);
        }

        public abstract ILogWriter createLogWriter();
    }
}
