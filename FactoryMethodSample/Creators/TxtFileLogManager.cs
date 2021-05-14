using FactoryMethodSample.Products.Interfaces;

namespace FactoryMethodSample.Creators
{
    public class TxtFileLogManager : LogManager
    {
        private string _filePath;

        public TxtFileLogManager(string filePath)
        {
            _filePath = filePath;
        }
        public override ILogWriter createLogWriter()
        {
            return new TxtFileLogWriter(_filePath);
        }
    }
}
