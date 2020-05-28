using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fast_minecraft_launcher.GUI
{
    class ConsoleTextBox : RichTextBox
    {
        public void WriteLine(string newLine)
        {
            if (!string.IsNullOrWhiteSpace(Text))
            {
                AppendText("\r\n" + newLine);
            }
            else
            {
                AppendText(newLine);
            }
            ScrollToCaret();
        }
    }
}
