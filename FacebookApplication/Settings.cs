using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookApplication
{
    public class Settings
    {
        public Size WindowSize { get; set; }

        public Point WindowLocation { get; set; }

        public string AccessToken { get; set; }

        public bool RememberMe { get; set; }

        public Settings()
        {
            WindowSize = new Size(614, 1570);
            WindowLocation = new Point(50, 50);
            AccessToken = null;
            RememberMe = false;
        }

        public static Settings LoadFromFile()
        {
            Settings savedSettings;

            try
            {
                using (Stream stream = new FileStream(@".\FacebookSettings.xml", FileMode.Open))
                {
                    Console.WriteLine(" load successful");
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                    savedSettings = serializer.Deserialize(stream) as Settings;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" didnt load");
                savedSettings = new Settings();
            }

            return savedSettings;
        }

        public void SaveToFile()
        {
            if (File.Exists(@".\FacebookSettings.xml"))
            {
                Console.WriteLine("  exists");
                createXMLFile(FileMode.Truncate);
            }
            else
            {
                Console.WriteLine(" didnt exists");
                createXMLFile(FileMode.Create);
            }
        }

        private void createXMLFile(FileMode i_Mode)
        {
            using (Stream stream = new FileStream(@".\FacebookSettings.xml", i_Mode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}