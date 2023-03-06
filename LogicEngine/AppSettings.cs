using System.IO;
using System.Xml.Serialization;
using ControlsFactory;

namespace LogicEngine
{
    public class AppSettings
    {
        private const string k_FilePath = @".\appSettings.xml";

        public string AccessToken { get; set; }

        public bool RememberUser { get; set; }

        public eControlsType ControlsType { get; set; }

        private AppSettings()
        {
            AccessToken = string.Empty;
            RememberUser = false;
            ControlsType = eControlsType.GrayControls;
        }

        public static AppSettings LoadAppSettingsFromFile()
        {
            AppSettings appSettings = null;

            if (File.Exists(k_FilePath))
            {
                using (Stream stream = new FileStream(k_FilePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveAppSettingsToFile()
        {
            FileMode fileMode;

            if (File.Exists(k_FilePath))
            {
                fileMode = FileMode.Truncate;
            }
            else
            {
                fileMode = FileMode.CreateNew;
            }

            using (Stream stream = new FileStream(k_FilePath, fileMode))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                xmlSerializer.Serialize(stream, this);
            }
        }
    }
}