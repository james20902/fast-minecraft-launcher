using fast_minecraft_launcher.GUI;

namespace fast_minecraft_launcher
{
    partial class MainWindow
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
            this.LogInConfirmButton = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SaveLoginInfo = new System.Windows.Forms.CheckBox();
            this.ConsoleLog = new ConsoleTextBox();
            this.ConsoleLogLabel = new System.Windows.Forms.Label();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LauncherPanel = new System.Windows.Forms.Panel();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginPanel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogInConfirmButton
            // 
            this.LogInConfirmButton.Location = new System.Drawing.Point(14, 154);
            this.LogInConfirmButton.Name = "LogInConfirmButton";
            this.LogInConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.LogInConfirmButton.TabIndex = 0;
            this.LogInConfirmButton.Text = "log in";
            this.LogInConfirmButton.UseVisualStyleBackColor = true;
            this.LogInConfirmButton.Click += new System.EventHandler(this.LogInConfirmButton_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(70, 15);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(100, 20);
            this.UsernameInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(70, 60);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(11, 18);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(11, 63);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveLoginInfo
            // 
            this.SaveLoginInfo.AutoSize = true;
            this.SaveLoginInfo.Location = new System.Drawing.Point(14, 96);
            this.SaveLoginInfo.Name = "SaveLoginInfo";
            this.SaveLoginInfo.Size = new System.Drawing.Size(91, 17);
            this.SaveLoginInfo.TabIndex = 5;
            this.SaveLoginInfo.Text = "stay logged in";
            this.SaveLoginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveLoginInfo.UseVisualStyleBackColor = true;
            this.SaveLoginInfo.CheckedChanged += new System.EventHandler(this.SaveLoginInfo_CheckedChanged);
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConsoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleLog.Location = new System.Drawing.Point(3, 38);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ReadOnly = true;
            this.ConsoleLog.Size = new System.Drawing.Size(305, 174);
            this.ConsoleLog.TabIndex = 8;
            this.ConsoleLog.Text = "";
            // 
            // ConsoleLogLabel
            // 
            this.ConsoleLogLabel.AutoSize = true;
            this.ConsoleLogLabel.Location = new System.Drawing.Point(3, 15);
            this.ConsoleLogLabel.Name = "ConsoleLogLabel";
            this.ConsoleLogLabel.Size = new System.Drawing.Size(66, 13);
            this.ConsoleLogLabel.TabIndex = 9;
            this.ConsoleLogLabel.Text = "Console Log";
            this.ConsoleLogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginPanel.Controls.Add(this.UsernameInput);
            this.LoginPanel.Controls.Add(this.LogInConfirmButton);
            this.LoginPanel.Controls.Add(this.UsernameLabel);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.SaveLoginInfo);
            this.LoginPanel.Controls.Add(this.PasswordInput);
            this.LoginPanel.Location = new System.Drawing.Point(12, 15);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(314, 215);
            this.LoginPanel.TabIndex = 10;
            // 
            // LauncherPanel
            // 
            this.LauncherPanel.Location = new System.Drawing.Point(12, 15);
            this.LauncherPanel.Name = "LauncherPanel";
            this.LauncherPanel.Size = new System.Drawing.Size(314, 215);
            this.LauncherPanel.TabIndex = 6;
            this.LauncherPanel.Visible = false;
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.Controls.Add(this.ConsoleLog);
            this.ConsolePanel.Controls.Add(this.ConsoleLogLabel);
            this.ConsolePanel.Location = new System.Drawing.Point(332, 15);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(311, 215);
            this.ConsolePanel.TabIndex = 11;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(111, 96);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(99, 17);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 242);
            this.Controls.Add(this.ConsolePanel);
            this.Controls.Add(this.LauncherPanel);
            this.Controls.Add(this.LoginPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "fast minecraft launcher";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInConfirmButton;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox SaveLoginInfo;
        private ConsoleTextBox ConsoleLog;
        private System.Windows.Forms.Label ConsoleLogLabel;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Panel LauncherPanel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
    }
}

