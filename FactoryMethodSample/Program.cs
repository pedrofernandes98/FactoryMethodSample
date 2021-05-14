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
            logManager.Log(LogType.INFO, "A aplicação foi inicializada!");
            logManager.Log(LogType.INFO, $"Tipo de log escolhido - {output}");
            logManager.Log(LogType.WARNING, "Gerando um log de Warning");
            logManager.Log(LogType.ERROR, "Um erro desconhecido ocorreu no fluxo de execução do programa!");
            logManager.Log(LogType.INFO, "Fim da Execução!");
            Console.ReadKey();
        }

        public static int getOutputType()
        {
            string output = AppConfigSettings.getSetting(nameof(OutputType));
            return Convert.ToInt32(output);
        }
    }
}
