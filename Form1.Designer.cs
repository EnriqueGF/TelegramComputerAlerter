namespace TelegramComputerMonitoring
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startupCheckbox = new System.Windows.Forms.CheckBox();
            this.botKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telegramUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testBotButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loadCredentialsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // startupCheckbox
            // 
            this.startupCheckbox.AutoSize = true;
            this.startupCheckbox.Checked = true;
            this.startupCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupCheckbox.Location = new System.Drawing.Point(14, 16);
            this.startupCheckbox.Name = "startupCheckbox";
            this.startupCheckbox.Size = new System.Drawing.Size(235, 17);
            this.startupCheckbox.TabIndex = 0;
            this.startupCheckbox.Text = "Auto startup invisible with Windows (Default)";
            this.startupCheckbox.UseVisualStyleBackColor = true;
            this.startupCheckbox.CheckedChanged += new System.EventHandler(this.startupCheckbox_CheckedChanged);
            // 
            // botKey
            // 
            this.botKey.Location = new System.Drawing.Point(144, 54);
            this.botKey.Name = "botKey";
            this.botKey.Size = new System.Drawing.Size(100, 20);
            this.botKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telegram Bot Api KEY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // telegramUserID
            // 
            this.telegramUserID.Location = new System.Drawing.Point(144, 80);
            this.telegramUserID.Name = "telegramUserID";
            this.telegramUserID.Size = new System.Drawing.Size(100, 20);
            this.telegramUserID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telegram User ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // testBotButton
            // 
            this.testBotButton.Location = new System.Drawing.Point(7, 117);
            this.testBotButton.Name = "testBotButton";
            this.testBotButton.Size = new System.Drawing.Size(116, 23);
            this.testBotButton.TabIndex = 5;
            this.testBotButton.Text = "Test Telegram Bot";
            this.testBotButton.UseVisualStyleBackColor = true;
            this.testBotButton.Click += new System.EventHandler(this.testBotButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "@EnriqueGF 2019";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loadCredentialsButton
            // 
            this.loadCredentialsButton.Location = new System.Drawing.Point(129, 117);
            this.loadCredentialsButton.Name = "loadCredentialsButton";
            this.loadCredentialsButton.Size = new System.Drawing.Size(138, 23);
            this.loadCredentialsButton.TabIndex = 8;
            this.loadCredentialsButton.Text = "Load Existing Credentials";
            this.loadCredentialsButton.UseVisualStyleBackColor = true;
            this.loadCredentialsButton.Click += new System.EventHandler(this.loadCredentialsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(79, 146);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Send Webcam Photo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(167, 181);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Send Text Message";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 228);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadCredentialsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testBotButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telegramUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botKey);
            this.Controls.Add(this.startupCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Text = "TelegramComputerMonitoring";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startupCheckbox;
        private System.Windows.Forms.TextBox botKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telegramUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testBotButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadCredentialsButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

