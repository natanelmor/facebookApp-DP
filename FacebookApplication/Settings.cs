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
                using (Stream stream = new FileStream(@"C:\temp\FacebookSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));

                    savedSettings = serializer.Deserialize(stream) as Settings;
                }
            }
            catch (Exception)
            {
                savedSettings = new Settings();
            }

            return savedSettings;
        }

        public void SaveToFile()
        {
            if (File.Exists(@"C:\temp\FacebookSettings.xml"))
            {
                createXMLFile(FileMode.Truncate);
            }
            else
            {
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