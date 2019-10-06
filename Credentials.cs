using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TelegramComputerMonitoring
{
    [Serializable]
    class Credentials
    {
        private static String directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\TelegramComputerAlerter\";
        private String botKey;
        private String telegramUserName;

        public Credentials(string botKey, string telegramUserName)
        {
            this.botKey = botKey;
            this.telegramUserName = telegramUserName;
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
        public static Credentials desserialize()
        {
            if (!File.Exists(directoryPath + "acc.dat"))
            {
                return null;
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(directoryPath + "acc.dat", FileMode.Open, FileAccess.Read);
            Credentials loginInfo = (Credentials)formatter.Deserialize(stream);
            stream.Close();
            return (loginInfo);
        }


        public string BotKey { get => botKey; set => botKey = value; }
        public string TelegramUserName { get => telegramUserName; set => telegramUserName = value; }
    }
}
