using System;
using System.Configuration;

namespace FactoryMethodSample
{
    public static class AppConfigSettings
    {
        public static string getSetting(string key)
        {
            string value = ConfigurationManager.AppSettings.Get(key);
            return value;
        }
    }
}
