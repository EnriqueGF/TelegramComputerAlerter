using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramComputerMonitoring
{
    public partial class mainForm : Form
    {
        private static RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public mainForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (startupCheckbox.Checked)
                {
                    registryKey.SetValue("TelegramComputerAlerter", Application.ExecutablePath);

                }
                else
                {
                    registryKey.DeleteValue("TelegramComputerAlerter");
                }
            }
            catch (Exception registrykeyException) { }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            Credentials credentials = new Credentials(botKey.Text, telegramUsername.Text);
            credentials.serialize();
        }

        private void loadCredentialsButton_Click(object sender, EventArgs e)
        {
            Credentials credentials = Credentials.desserialize();

            if (credentials != null)
            {

                botKey.Text = credentials.BotKey;
                telegramUsername.Text = credentials.TelegramUserName;

            }

        }
    }
}
