using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Configuration;

namespace CurrencyTracker
{
    static class Program
    {
        private static String DataSource = Properties.Settings.Default.Database1ConnectionString;

        private static String Upgrade = ConfigurationManager.AppSettings["upgrade"];
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            int upgrade = int.Parse(Upgrade);

            if (upgrade == 0)
            {
                SqlCeEngine engine = new SqlCeEngine(DataSource);
                engine.Upgrade(DataSource);

                UpdateSetting("upgrade", "1");
            }

            Application.Run(new Form1());
        }

        private static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
