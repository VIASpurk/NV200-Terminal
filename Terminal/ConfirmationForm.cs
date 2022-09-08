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
      
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmationForm_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
