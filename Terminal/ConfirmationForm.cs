using NetworkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
            if (!SettingsTerminal.Instance.Debug)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                ControlBox = false;
                MaximizeBox = false;
            }
        }
        IServerProxy serverProxy;
        public int time = 60;
        
        public static void Replenish(int PCName, int cash, string nameWindow, IServerProxy serverProxy, IWin32Window owner)
        {
            using (ConfirmationForm cf = new ConfirmationForm())
            {
                cf.serverProxy = serverProxy;
                cf.serverProxy.Replenish(PCName, cash);
                cf.Text = nameWindow;
                DialogResult dialogcf = cf.ShowDialog(owner);
            }

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmationForm_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
