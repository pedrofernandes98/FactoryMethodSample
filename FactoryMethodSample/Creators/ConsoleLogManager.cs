using FactoryMethodSample.Products.Interfaces;

namespace FactoryMethodSample.Creators
{
    public class ConsoleLogManager : LogManager
    {
        public override ILogWriter createLogWriter()
        {
            return new ConsoleLogWriter();
        }
    }
}
