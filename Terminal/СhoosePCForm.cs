using ComponentFactory.Krypton.Toolkit;
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
    public partial class СhoosePCForm : Form
    {
        private KryptonButton selectedButton;

        public СhoosePCForm()
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

        public static int? GetPCName(string title, IWin32Window owner)
        {
            using (СhoosePCForm choosePC = new СhoosePCForm())
            {
                choosePC.Text = title;
                choosePC.labelChoiseText.Text = title;

                DialogResult dr = choosePC.ShowDialog(owner);

                if (dr == DialogResult.Cancel || choosePC.selectedButton == null)
                {
                    return null;
                }

                if (int.TryParse(choosePC.selectedButton.Text, out int pc))
                {
                    return pc;
                }
            }
            return null;
        }

        private void DepositingForm_Load(object sender, EventArgs e)
        {
            int numberPC = SettingsTerminal.Instance.CountPC;
            kryptonButtonNext.Visible = false;

            List<KryptonButton> listButton = new List<KryptonButton>();

            listButton.Add(kryptonButton1);
            listButton.Add(kryptonButton2);
            listButton.Add(kryptonButton3);
            listButton.Add(kryptonButton4);
            listButton.Add(kryptonButton5);
            listButton.Add(kryptonButton6);
            listButton.Add(kryptonButton7);
            listButton.Add(kryptonButton8);
            listButton.Add(kryptonButton9);
            listButton.Add(kryptonButton10);
            listButton.Add(kryptonButton11);
            listButton.Add(kryptonButton12);
            listButton.Add(kryptonButton13);
            listButton.Add(kryptonButton14);
            listButton.Add(kryptonButton15);
            listButton.Add(kryptonButton16);
            listButton.Add(kryptonButton17);
            listButton.Add(kryptonButton18);
            listButton.Add(kryptonButton19);
            listButton.Add(kryptonButton20);
            listButton.Add(kryptonButton21);
            listButton.Add(kryptonButton22);
            listButton.Add(kryptonButton23);
            listButton.Add(kryptonButton24);
            listButton.Add(kryptonButton25);

            for (int i = numberPC; i <= listButton.Count - 1; i++)
            {
                listButton[i].Visible = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerChoisePC_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void PCButton_Click(object sender, EventArgs e)
        {
            KryptonButton button = (KryptonButton)sender;
            SelectButton(button);
            kryptonButtonNext.Visible = true;
        }

        private void SelectButton(KryptonButton newButton)
		{
            if (newButton == selectedButton)
			{
                return;
			}

            if (selectedButton != null)
			{
                selectedButton.StateNormal.Back.Color1 = selectedButton.StateCommon.Back.Color1;
                selectedButton.StateNormal.Back.Color2 = selectedButton.StateCommon.Back.Color2;
                selectedButton.StateTracking.Back.Color1 = selectedButton.StateCommon.Back.Color1;
                selectedButton.StateTracking.Back.Color2 = selectedButton.StateCommon.Back.Color2;
                selectedButton.OverrideFocus.Back.Color1 = selectedButton.StateCommon.Back.Color1;
                selectedButton.OverrideFocus.Back.Color2 = selectedButton.StateCommon.Back.Color2;
                selectedButton.OverrideDefault.Back.Color1 = selectedButton.StateCommon.Back.Color1;
                selectedButton.OverrideDefault.Back.Color2 = selectedButton.StateCommon.Back.Color2;
            }

            selectedButton = newButton;
            selectedButton.StateNormal.Back.Color1 = selectedButton.StatePressed.Back.Color1;
            selectedButton.StateNormal.Back.Color2 = selectedButton.StatePressed.Back.Color2;
            selectedButton.StateTracking.Back.Color1 = selectedButton.StatePressed.Back.Color1;
            selectedButton.StateTracking.Back.Color2 = selectedButton.StatePressed.Back.Color2;
            selectedButton.OverrideFocus.Back.Color1 = selectedButton.StatePressed.Back.Color1;
            selectedButton.OverrideFocus.Back.Color2 = selectedButton.StatePressed.Back.Color2;
            selectedButton.OverrideDefault.Back.Color1 = selectedButton.StatePressed.Back.Color1;
            selectedButton.OverrideDefault.Back.Color2 = selectedButton.StatePressed.Back.Color2;
        }
    }
}
