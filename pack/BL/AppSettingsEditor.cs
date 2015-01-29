using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientZipUnZip.BL
{
    internal static class AppSettingsEditor
    {
        /// <summary> Отримує повну назву в залежності від фізичного 
        /// знаходження файла програми. </summary>
        /// <returns>Повний шлях з назвою файлу</returns>
        private static string GetExePath()
        {
            string applicationName =
                Application.ProductName + ".exe";

            string exePath = System.IO.Path.Combine(
                Environment.CurrentDirectory, applicationName);

            return exePath.Replace(".exe.exe", ".exe");
        }

        /// <summary> Додає ключ та значення в appSettings. </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значення</param>
        public static void AddAppSetting(String key, String value)
        {
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(GetExePath());
            config.AppSettings.Settings.Add(key, value);
            try
            {
                config.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary> Поновлеє значення по ключі в appSettings. </summary>
        /// <param name="key">Ключ</param>
        /// <param name="value">Значення</param>
        public static void ChangeAppSettings(string key, String value)
        {
            if (ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                Configuration config =
                    ConfigurationManager.OpenExeConfiguration(GetExePath());
                config.AppSettings.Settings.Remove(key);
                config.AppSettings.Settings.Add(key, value);
                try
                {
                    config.Save(ConfigurationSaveMode.Full);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
