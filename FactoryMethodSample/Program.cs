using FactoryMethodSample.Creators;
using FactoryMethodSample.ValueObj;
using System;
using System.Configuration;

namespace FactoryMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputType output = (OutputType)getOutputType();
            LogManager logManager = SimpleLogManager.getLogManager(output);

            logManager.Log("Warning", "Teste");
            logManager.Log("Error", "LogManager");
            Console.ReadKey();
        }

        public static int getOutputType()
        {
            string output = ConfigurationManager.AppSettings.Get("OutputType");
            return Convert.ToInt32(output);
        }
    }
}
