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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        IServerProxy serverProxy;
        TechnicalBreakForm technicalBreakForm;
        ITerminal terminal;

        private void Depositing_Click(object sender, EventArgs e)
        {
            string nameWindow = "ПОПОЛНЕНИЕ";
            Deposit(nameWindow);
        }


        private void Withdrawal_Click(object sender, EventArgs e)
        {
            string nameWindow = "СНЯТИЕ";
            OperationWithdrawal(nameWindow);
        }

        public void Deposit(string nameWindow)
        {
            int? PC = СhoosePCForm.GetPCName(nameWindow, this);
            if (PC != null)
            {
                int? cash = Intoduction.GetCashTerminal(PC, this);
                if (cash != null)
                {
                    ConfirmationForm.Replenish(PC.Value, cash.Value, nameWindow, serverProxy, this);
                }
            }
        }

        public void OperationWithdrawal(string nameWindow)
        {
            int? PC = СhoosePCForm.GetPCName(nameWindow, this);
            if (PC != null)
            {
                WaitingPaymentForm.SetCashAndPC(PC.Value, serverProxy, this);
            }
        }

        private void BeginWindow_Load(object sender, EventArgs e)
        {
            kryptonButtonDepositing.Font = new Font("Tahoma", 20.25F, System.Drawing.FontStyle.Italic);
            if (!SettingsTerminal.Instance.Debug)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                ControlBox = false;
                MaximizeBox = false;
            }
        }

        private void ServerProxy_CancelTechnicalBreak()
        {
            if (technicalBreakForm != null)
            {
                technicalBreakForm.Close();
            }
        }

        private void ServerProxy_TechnicalBreak()
        {
            technicalBreakForm = new TechnicalBreakForm();
            technicalBreakForm.ShowDialog();
        }

        private void BeginWindow_Shown(object sender, EventArgs e)
        {
            try
            {
                _ = SettingsTerminal.Instance;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки настроек" + ex.Message);
            }
            try
            {
                serverProxy = ClientConnection.ConnectToServer(SettingsTerminal.Instance.NameServer);
                serverProxy.TechnicalBreak += ServerProxy_TechnicalBreak;
                serverProxy.CancelTechnicalBreak += ServerProxy_CancelTechnicalBreak;
				serverProxy.NeedCashInfo += ServerProxy_NeedCashInfo;

                if (SettingsTerminal.Instance.EmulateMode)
                {
                    terminal = Terminal.RunEmulator();
                }
                else
				{
                    terminal = Terminal.ConnectToDevice(SettingsTerminal.Instance.ComPort);
				}
            }
            catch
            {
                MessageBox.Show(this, "Сервер не доступен");
                Close();
            }
        }

		private void ServerProxy_NeedCashInfo()
		{
			var data = terminal.GetInfo()
                .Select(x => new CashInfo() 
                { 
                    Value = x.Value, 
                    Count = x.Level 
                })
                .ToArray();
            serverProxy.SendCashInfo(data);
		}

		private void kryptonButton1_Click(object sender, EventArgs e)
        {
            string nameWindow = "ПОПОЛНЕНИЕ";
            Deposit(nameWindow);
        }

        private void kryptonButtonWithdrawal_Click(object sender, EventArgs e)
        {
            string nameWindow = "СНЯТИЕ";
            OperationWithdrawal(nameWindow);
        }
    }
}
