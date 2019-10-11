using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramComputerMonitoring
{
    [Serializable]
    class UserSettings
    {
        private static String directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TelegramComputerAlerter\";
        private String botKey;
        private String telegramID;

        public UserSettings(string botKey, string telegramUserName)
        {
            this.botKey = botKey;
            this.telegramID = telegramUserName;
        }

        public void serialize()
        {
            IFormatter formatter = new BinaryFormatter();
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);

            }
            Stream stream = new FileStream(directoryPath + "acc.dat", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, this);
            stream.Close();
        }
        public static UserSettings unserialize()
        {
            try { 
            if (!File.Exists(directoryPath + "acc.dat"))
            {
                return null;
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(directoryPath + "acc.dat", FileMode.Open, FileAccess.Read);
            UserSettings loginInfo = (UserSettings)formatter.Deserialize(stream);
            stream.Close();
            return (loginInfo);
            } catch (Exception ex) { MessageBox.Show("Error ocurred reading saved file"); }

            return null;
        }
        public string BotKey { get => botKey; set => botKey = value; }
        public string TelegramID { get => telegramID; set => telegramID = value; }
        public static string DirectoryPath { get => directoryPath; set => directoryPath = value; }
    }
}
