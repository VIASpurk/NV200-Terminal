using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Intoduction : Form
    {
        private int? Cash { get; set; }

        public Intoduction()
        {
            InitializeComponent();
        }

        public static int? GetCashTerminal(int? namePC, IWin32Window owner)
        {
            using (Intoduction intoduction = new Intoduction())
            {
                intoduction.labelIntroductonPC.Text = "Компьютер № " + namePC;
                DialogResult intr = intoduction.ShowDialog(owner);

                if (intr == DialogResult.OK)
                {
                    return intoduction.Cash;

                }

                return null;
            }
        }

        private void IntoductionDebug_Click(object sender, EventArgs e)
        {
            timerIntroduction.Enabled = false;
            DebugForm debugForm = new DebugForm();
            DialogResult dr = debugForm.ShowDialog();

            if (dr == DialogResult.OK)
            {

                Cash = debugForm.GetCash();
                labelCash.Text = Cash.ToString();
                kryptonButtonIntoductionCancel.Visible = false;
                kryptonButtonIntoductionNext.Visible = true;
            }
            else
            {
                timerIntroduction.Enabled = true;
            }
        }

        private void Intoduction_Load(object sender, EventArgs e)
        {
            timerIntroduction.Enabled = true;
            kryptonButtonIntoductionNext.Visible = false;

            if (!SettingsTerminal.Instance.Debug)
            {
                IntoductionDebug.Visible = false;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                ControlBox = false;
                MaximizeBox = false;
            }
        }

        private void Intoduction_Shown(object sender, EventArgs e)
        {
            timerIntroduction.Enabled = true;
        }

        private void timerIntroduction_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}

