using Emgu.CV;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace TelegramComputerMonitoring
{
    public partial class mainForm : Form
    {
        private static RegistryKey runRegistry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private static String AppRegistryKeyName = "TelegramComputerAlerter";
        public string TEST_MESSAGE = "TelegramComputerMonitoring test message.";
        UserSettings credentials;
        TelegramBotClient botClient;

        public mainForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void startupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (startupCheckbox.Checked)
                {
                    runRegistry.SetValue(AppRegistryKeyName, Application.ExecutablePath + " /startup");

                }
                else
                {
                    runRegistry.DeleteValue(AppRegistryKeyName);
                }
            }
            catch (Exception) { }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (runRegistry.GetValue(AppRegistryKeyName) == null)
            {
                startupCheckbox.Checked = false;

            } else
            {
                startupCheckbox.Checked = true;
            }

            loadCredentials();
            
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            // Event called when form is completly shown
            if (isStartup()) {
                sendInfoThroughTelegram();
                createExitTimer();
            }

            hide();
        }

        private void createExitTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Application.Exit();
        }

        private void hide()
        {
            if (isStartup()) { this.Hide(); }

        }

        private bool isStartup()
        {
            foreach (String parameter in Environment.GetCommandLineArgs())
            {
                if (parameter.Equals("/startup"))
                {
                    return true;
                }
            };
            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            credentials = new UserSettings(botKey.Text, telegramUserID.Text, checkBox2.Checked, checkBox1.Checked);
            credentials.serialize();
            MessageBox.Show("Saved.");
        }

        private void loadCredentialsButton_Click(object sender, EventArgs e)
        {
            loadCredentials();
        }

        private void loadCredentials()
        {
            credentials = UserSettings.unserialize();

            if (credentials != null)
            {
                if (credentials.SendPhoto) { checkBox1.Checked = true; }
                if (credentials.SendText) { checkBox2.Checked = true; }

                botKey.Text = credentials.BotKey;
                telegramUserID.Text = credentials.TelegramID;
                botClient = new TelegramBotClient(credentials.BotKey);
            }
        }

        private void testBotButton_Click(object sender, EventArgs e)
        {
            bool errorOcurred = false;
            try {
                botClient.SendTextMessageAsync(credentials.TelegramID, TEST_MESSAGE);

            } catch (Exception requestException) { MessageBox.Show("An error ocurred, please check your Bot API key:\n " + requestException); errorOcurred = true; }

            if (!errorOcurred) { MessageBox.Show("The message has been sent without any errors."); }
        }

        private void sendInfoThroughTelegram()
        {
            if (credentials.SendPhoto) {
                sendCameraPhoto();
            }

            if (credentials.SendText)
            {
                sendTextMessage();
            }
        }

        private void sendTextMessage()
        {
            botClient.SendTextMessageAsync(credentials.TelegramID, "New login!");
        }

        private async void sendCameraPhoto()
        {
            if (File.Exists(UserSettings.DirectoryPath + "lastImage.jpeg"))
            {
                File.Delete(UserSettings.DirectoryPath + "lastImage.jpeg");
            }

            VideoCapture capture = new VideoCapture();
            Bitmap image = capture.QueryFrame().Bitmap;
            image.Save(UserSettings.DirectoryPath + "lastImage.jpeg");
            using (FileStream fs = System.IO.File.OpenRead(UserSettings.DirectoryPath + "lastImage.jpeg"))
            {
                InputOnlineFile inputOnlineFile = new InputOnlineFile(fs, "image.jpeg");
                await botClient.SendPhotoAsync(credentials.TelegramID, inputOnlineFile);
            }
        }
    }
}
