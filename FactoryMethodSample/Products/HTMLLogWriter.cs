using FactoryMethodSample.Products.Interfaces;
using System.IO;

namespace FactoryMethodSample.Products
{
    public class HTMLLogWriter : ILogWriter
    {
        public string _filePath { get; }
        public HTMLLogWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(string message)
        {
            string htmlContent = "";
            if (!File.Exists(_filePath))
            {
                htmlContent = GenerateHTMLCode(message);
            }
            else
            {
                string content = File.ReadAllText(_filePath);
                int index = content.IndexOf("</ul>");
                htmlContent = content.Substring(0, index)
                    + "<li>" + message + "</li>"
                    + content.Substring(index);
            }

            using(StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.Write(htmlContent);
            }

        }

        public string GenerateHTMLCode(string message)
        {
            string html = "";

            html += "<!DOCTYPE html>"
            + "<html lang=\u0022pt-br\u0022>"
            + "<head>"
            + "<title>Log</title>"
            + "<meta charset=\u0022utf-8\u0022>"
            + "</head>"
            + "<body>"
            + "<h1>Log - FactoryMethodSample</h1>"
            + "<ul>"
            + "<li>" + message + "</li>"
            + "</ul>"
            + "</body>"
            + "</html>";

            return html;
        }


    }
}
