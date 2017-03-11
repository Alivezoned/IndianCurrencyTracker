using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Threading;

namespace CurrencyTracker
{
    class Api
    {
        private float currency = 0;

        public float GetCurrencyBackground()
        {
            Thread thread = new Thread(GetCurrencyBG) { IsBackground = true };
            thread.Start();

            if (currency > 0)
            {
                return currency;
            }
            else { return 0; }
        }
        public void GetCurrencyBG()
        {
            /* Currency API for USD -> INR
             * http://query.yahooapis.com/v1/public/yql?q=select%20%2a%20from%20yahoo.finance.xchange%20where%20pair%20in%20%28%22USDEUR%22,%20%22USDINR%22,%20%22USDISK%22%29&env=store://datatables.org/alltableswithkeys
             * */
            try
            {
                String url = @"http://query.yahooapis.com/v1/public/yql?q=select%20%2a%20from%20yahoo.finance.xchange%20where%20pair%20in%20%28%22USDEUR%22,%20%22USDINR%22,%20%22USDISK%22%29&env=store://datatables.org/alltableswithkeys";

                XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
                xmlDoc.Load(url); // Load the XML document from the specified file

                // Get elements
                XmlNodeList Name = xmlDoc.GetElementsByTagName("Name");
                XmlNodeList Rate = xmlDoc.GetElementsByTagName("Rate");

                float ExactRate = float.Parse(Rate[1].InnerText.ToString());
                currency = ExactRate;
            }
            catch (Exception ex)
            {
            }
        }

        public float GetCurrency()
        {
            /* Currency API for USD -> INR
             * http://query.yahooapis.com/v1/public/yql?q=select%20%2a%20from%20yahoo.finance.xchange%20where%20pair%20in%20%28%22USDEUR%22,%20%22USDINR%22,%20%22USDISK%22%29&env=store://datatables.org/alltableswithkeys
             * */
            try
            {
                String url = @"http://query.yahooapis.com/v1/public/yql?q=select%20%2a%20from%20yahoo.finance.xchange%20where%20pair%20in%20%28%22USDEUR%22,%20%22USDINR%22,%20%22USDISK%22%29&env=store://datatables.org/alltableswithkeys";

                XmlDocument xmlDoc = new XmlDocument(); // Create an XML document object
                xmlDoc.Load(url); // Load the XML document from the specified file

                // Get elements
                XmlNodeList Name = xmlDoc.GetElementsByTagName("Name");
                XmlNodeList Rate = xmlDoc.GetElementsByTagName("Rate");

                float ExactRate = float.Parse(Rate[1].InnerText.ToString());

                return ExactRate;
            }
            catch (Exception ex)
            {
                String line = "________________________________";
                Console.WriteLine(ex.Message);
                Console.WriteLine(line);
                Console.WriteLine(line);
                Console.WriteLine(ex.StackTrace.ToString());
                Console.WriteLine(line);
                Console.WriteLine(line);
                Console.WriteLine(ex.TargetSite.ToString());
                Console.WriteLine(line);
                Console.WriteLine(line);
                Console.WriteLine(ex.Source.ToString());

                return GetCurrency();
            }
        }

        public float AverageCurrency(List<float> list)
        {
            float final = 0;

            int listLength = list.Count;

            for (int i = 0; i < listLength; i++)
            {
                final += list[i];
            }

            final = final / listLength;

            return final;
        }

        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public void FileWrite(String mFileName, String Text)
        {
            String fileName = @"\" + mFileName + ".txt";

            string path = Environment.CurrentDirectory + fileName;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(Text);
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path, true);
                tw.WriteLine(Text);
                tw.Close();
            }
        }

        public static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
