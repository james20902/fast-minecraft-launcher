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
            this.ConsoleLog = new System.Windows.Forms.RichTextBox();
            this.ConsoleLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInConfirmButton
            // 
            this.LogInConfirmButton.Location = new System.Drawing.Point(30, 180);
            this.LogInConfirmButton.Name = "LogInConfirmButton";
            this.LogInConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.LogInConfirmButton.TabIndex = 0;
            this.LogInConfirmButton.Text = "log in";
            this.LogInConfirmButton.UseVisualStyleBackColor = true;
            this.LogInConfirmButton.Click += new System.EventHandler(this.LogInConfirmButton_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(86, 41);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(100, 20);
            this.UsernameInput.TabIndex = 1;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(86, 86);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 20);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(27, 44);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(53, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(27, 89);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(52, 13);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "password";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveLoginInfo
            // 
            this.SaveLoginInfo.AutoSize = true;
            this.SaveLoginInfo.Location = new System.Drawing.Point(30, 122);
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
            this.ConsoleLog.Location = new System.Drawing.Point(332, 30);
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ReadOnly = true;
            this.ConsoleLog.Size = new System.Drawing.Size(311, 173);
            this.ConsoleLog.TabIndex = 8;
            this.ConsoleLog.Text = "";
            // 
            // ConsoleLogLabel
            // 
            this.ConsoleLogLabel.AutoSize = true;
            this.ConsoleLogLabel.Location = new System.Drawing.Point(332, 11);
            this.ConsoleLogLabel.Name = "ConsoleLogLabel";
            this.ConsoleLogLabel.Size = new System.Drawing.Size(66, 13);
            this.ConsoleLogLabel.TabIndex = 9;
            this.ConsoleLogLabel.Text = "Console Log";
            this.ConsoleLogLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 242);
            this.Controls.Add(this.ConsoleLogLabel);
            this.Controls.Add(this.ConsoleLog);
            this.Controls.Add(this.SaveLoginInfo);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.LogInConfirmButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.Text = "fast minecraft launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInConfirmButton;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox SaveLoginInfo;
        private System.Windows.Forms.RichTextBox ConsoleLog;
        private System.Windows.Forms.Label ConsoleLogLabel;
    }
}

