using System;
using System.Windows.Forms;
using fast_minecraft_launcher.MojangAccount;
using fast_minecraft_launcher.MojangAccount.Payload;

namespace fast_minecraft_launcher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void LogInConfirmButton_Click(object sender, EventArgs e)
        {
            ConsoleLog.WriteLine("Log in pressed");
            LogInConfirmButton.Enabled = false;
            LogInConfirmButton.Text = "logging in";
            await MojangAuthentication.getInstance().GetAuthenticationResponse(new AuthenticationPayload(UsernameInput.Text, PasswordInput.Text));
            ConsoleLog.WriteLine("Response received");
            LogInConfirmButton.Enabled = true;
            LogInConfirmButton.Text = "log in";
        }

        private void SaveLoginInfo_CheckedChanged(object sender, EventArgs e)
        {
            ConsoleLog.WriteLine("Save login checked");
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordInput.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }
}
