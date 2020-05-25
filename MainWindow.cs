using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_minecraft_launcher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogInConfirmButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There's nothing here yet");
            ConsoleLog.AppendText("log in pressed");
        }

        private void SaveLoginInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveLoginInfo.Checked)
            {
                PermenantLoginWarning.Visible = true;
                PermenantLogin.Visible = true;
            }
            else
            {
                PermenantLoginWarning.Visible = false;
                PermenantLogin.Visible = false;
                PermenantLogin.Checked = false;
            }
            ConsoleLog.AppendText("checkbox changed");
        }
    }
}
