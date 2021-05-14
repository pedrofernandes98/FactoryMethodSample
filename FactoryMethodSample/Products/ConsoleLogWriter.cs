using FactoryMethodSample.Products.Interfaces;
using System;

namespace FactoryMethodSample
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
