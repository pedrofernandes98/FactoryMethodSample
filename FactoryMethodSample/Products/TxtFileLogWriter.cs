using FactoryMethodSample.Products.Interfaces;
using System.IO;

namespace FactoryMethodSample
{
    public class TxtFileLogWriter : ILogWriter
    {
        public string _filePath { get;}

        public TxtFileLogWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(string message)
        {
            using(StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(message);
            }
        }
    }
}
