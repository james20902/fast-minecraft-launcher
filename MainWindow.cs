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
            ConsoleLog.AppendText("log in pressed");
            await MojangAuthentication.sendRequest(new AuthenticationPayload(UsernameInput.Text, PasswordInput.Text));
            LogInConfirmButton.Enabled = false;
            LogInConfirmButton.Text = "Logging in";
        }

        private async void SaveLoginInfo_CheckedChanged(object sender, EventArgs e)
        {
            ConsoleLog.AppendText("checkbox changed");
        }
    }
}
