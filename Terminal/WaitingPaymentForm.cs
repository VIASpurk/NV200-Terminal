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
using System.Xml.Linq;
using Terminal.Controls;
using TerminalLibrary;

namespace Terminal
{
    public partial class WaitingPaymentForm : Form
    {
        IServerProxy serverProxy;
        ITerminal terminal;
        

        private bool waitTerminalPayout;
        public int time = 60;
        public int errorTime = 5;
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

        public static void SetCashAndPC(int PCName1, IServerProxy serverProxy, IWin32Window owner, ITerminal terminal)
        {
            using (WaitingPaymentForm wp = new WaitingPaymentForm())
            {
                wp.serverProxy = serverProxy;
                wp.terminal = terminal;
                wp.PCName = PCName1;
                DialogResult dialogcf = wp.ShowDialog(owner);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
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
                WaitTimer.Enabled = false;
                tabControl1.SelectedTab = TabPageLater;
                ErrorTimer.Enabled = true;
            }
            
        }

        private void ConfirmationForm_Shown(object sender, EventArgs e)
        {
            WaitTimer.Enabled = true;
            serverProxy.Payment += ServerProxy_Payment;
            serverProxy.PayoutRequest(PCName);
            
            roundCorneredProgressBar1.Animate();


        }

        private void ServerProxy_Payment(PayoutData obj)
        {
            serverProxy.Payment -= ServerProxy_Payment;
            PayoutResult payoutResult = new PayoutResult();
            payoutResult.PCName = obj.PCName;
            payoutResult.Quantity = obj.Quantity;
            

            try
            {
                if (terminal.CanPayout(obj.Quantity, out string error) &&
                    terminal.Payout(obj.Quantity, out error))
                {
                    WaitTimer.Enabled = false;
                    Invoke(new Action(() =>
                    {
                        PayoutLabel.Text = obj.Quantity.ToString();
                        tabControl1.SelectedTab = TabPagePayout;
                    }));

                    terminal.PayoutCash += Terminal_PayoutCash;
                    waitTerminalPayout = true;
                    

                    while (waitTerminalPayout)
                    {
                        Thread.Sleep(1);
                    }
                }
                else
                {
                    payoutResult.ErrorMessage = error;
                }
            }
            catch (Exception exc)
            {
                payoutResult.ErrorMessage = "Ошибка: " + exc.Message;
            }
            serverProxy.PayoutResult(payoutResult);

            this.Invoke(new Action(() =>
            {
                Close();
            }));
        }

		private void Terminal_PayoutCash(int obj)
		{
            terminal.PayoutCash -= Terminal_PayoutCash;
            waitTerminalPayout = false;
        }

		private void WaitingPaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverProxy.Payment -= ServerProxy_Payment;
        }

		private void ErrorTimer_Tick(object sender, EventArgs e)
		{
            errorTime--;

            if (errorTime == 0)
            {
                ErrorTimer.Enabled = false;
                Close();
            }
        }

        
    }
}
