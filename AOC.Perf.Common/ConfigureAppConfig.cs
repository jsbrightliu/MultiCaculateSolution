using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AOC.Perf.Common
{
    public class ConfigureAppConfig
    {
        static ConfigureAppConfig() { }
        public static string GetAppSettingsKeyValue(string keyName)
        {
            return ConfigurationManager.AppSettings.Get(keyName);
        }
        public static string GetConnectionStringsElementValue(string ConnectionStringsName)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[ConnectionStringsName];
            return settings.ConnectionString;
        }

        public static void ConnectionStringsSave(string ConnectionStringsName, string elementValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings[ConnectionStringsName].ConnectionString = elementValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        private static bool AppSettingsKeyExists(string strKey, Configuration config)
        {
            foreach (string str in config.AppSettings.Settings.AllKeys)
            {
                if (str == strKey)
                {
                    return true;
                }
            }
            return false;
        }
        public static void AppSettingsSave(string strKey, string newValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (AppSettingsKeyExists(strKey, config))
            {
                config.AppSettings.Settings[strKey].Value = newValue;config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
    }
}
