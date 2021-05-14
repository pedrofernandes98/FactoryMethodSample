using FactoryMethodSample.Products;
using FactoryMethodSample.Products.Interfaces;

namespace FactoryMethodSample.Creators
{
    public class HTMLLogManager : LogManager
    {
        private string _filePath;

        public HTMLLogManager(string filePath)
        {
            _filePath = filePath;
        }

        public override ILogWriter createLogWriter()
        {
            return new HTMLLogWriter(_filePath);
        }
    }
}
