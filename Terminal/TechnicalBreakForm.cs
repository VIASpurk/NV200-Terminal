using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class TechnicalBreakForm : Form
    {
        public TechnicalBreakForm()
        {
            InitializeComponent();
        }

        private void TechnicalBreakForm_Load(object sender, EventArgs e)
        {
            if (!SettingsTerminal.Instance.Debug)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
