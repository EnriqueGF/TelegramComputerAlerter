using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramComputerMonitoring
{
    class Credentials
    {
        private static String botKey;
        private static String telegramUserName;

        public static string BotKey { get => botKey; set => botKey = value; }
        public static string TelegramUserName { get => telegramUserName; set => telegramUserName = value; }
    }
}
