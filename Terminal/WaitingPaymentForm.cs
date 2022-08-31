using NetworkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Terminal
{
    public partial class WaitingPaymentForm : Form
    {
        IServerProxy serverProxy;
        public int time = 60;
        public int time2 = 65;
        private int PCName;

        public WaitingPaymentForm()
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

        public static void SetCashAndPC(int PCName1, IServerProxy serverProxy, IWin32Window owner)
        {
            using (WaitingPaymentForm wp = new WaitingPaymentForm())
            {
                wp.serverProxy = serverProxy;
                wp.PCName = PCName1;
                DialogResult dialogcf = wp.ShowDialog(owner);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            time2 = time2 - 1;
            if (time < 10)
            {
                labelTimeWaiting.Text = "0" + time.ToString();
            }
            else
            {
                labelTimeWaiting.Text = time.ToString();
            }

            if (time == 0)
            {
                pictureBoxWaiting.Visible = false;
                labelTimeWaiting.Visible = false;
                labelInfoWaiting.Visible = true;
            }
            if (time2 == 0)
            {
                timer1.Enabled = false;
                Close();
            }
        }

        private void ConfirmationForm_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            labelInfoWaiting.Visible = false;
            serverProxy.Payment += ServerProxy_Payment;
            serverProxy.PayoutRequest(PCName);
        }

        private void ServerProxy_Payment(PayoutData obj)
        {
            serverProxy.Payment -= ServerProxy_Payment;
            PayoutResult payoutResult = new PayoutResult();
            payoutResult.PCName = obj.PCName;
            payoutResult.Quantity = obj.Quantity;
           
                this.Invoke(new Action(() =>
                {
                if (SettingsTerminal.Instance.Debug)
                {

                    var result = MessageBox.Show(this, "Выдача на компьютер № " + obj.PCName + " В количестве " + obj.Quantity + " руб.", "Отправить подтверждение?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        payoutResult.ErrorMessage = "Ошибка";
                    }
                    
                 }
                    serverProxy.PayoutResult(payoutResult);
                    Close();
                }));
       
        }

        private void WaitingPaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverProxy.Payment -= ServerProxy_Payment;
        }

        private void WaitingPaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
