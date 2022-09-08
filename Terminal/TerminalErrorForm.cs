using NetworkLibrary;
using NetworkLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary;

namespace Terminal
{
    public partial class TerminalErrorForm : Form
    {
        public TerminalErrorForm()
        {
            InitializeComponent();

            if (!SettingsTerminal.Instance.Debug)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
