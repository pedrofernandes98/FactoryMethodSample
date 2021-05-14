using FactoryMethodSample.ValueObj;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodSample.Creators
{
    public static class SimpleLogManager
    {
        public static LogManager getLogManager(OutputType type)
        {
            LogManager logManager = null;
            switch (type)
            {
                case OutputType.Console: logManager = new ConsoleLogManager(); break;
                case OutputType.TxtFile: logManager = new TxtFileLogManager("C:\\Log\\log.txt"); break;
            }

            return logManager;
        }
    }
}
