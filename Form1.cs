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
using System.Windows.Forms;


namespace TelegramComputerMonitoring
{
    public partial class mainForm : Form
    {
        private static RegistryKey runRegistry = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private static String AppRegistryKeyName = "TelegramComputerAlerter";
        Credentials credentials;


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
            catch (Exception registrykeyException) { }
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
            hideOnStartup();
        }

        private void hideOnStartup()
        {
            foreach (String parameter in Environment.GetCommandLineArgs())
            {
                if (parameter.Equals("/startup"))
                {
                    this.Hide();
                }
            };
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
            credentials = new Credentials(botKey.Text, telegramUserID.Text);
            credentials.serialize();
        }

        private void loadCredentialsButton_Click(object sender, EventArgs e)
        {
            loadCredentials();
        }

        private void loadCredentials()
        {
            credentials = Credentials.unserialize();

            if (credentials != null)
            {
                botKey.Text = credentials.BotKey;
                telegramUserID.Text = credentials.TelegramID;
            }
        }

        private void testBotButton_Click(object sender, EventArgs e)
        {
            String url = "https://api.telegram.org/bot" + credentials.BotKey + "/sendMessage?chat_id=" + credentials.TelegramID + "&text=" + " TelegramComputerMonitoring test message.";
            String htmlCode = String.Empty;
            bool errorOcurred = false;
            try { 
                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString(url);
                }
            } catch (Exception requestException) { MessageBox.Show("An error ocurred, please check your Bot API key:\n " + requestException); errorOcurred = true; }

            if (!errorOcurred) { MessageBox.Show("The message has been sent without any errors."); }
        }
    }
}
