using NetworkLibrary;
using NetworkLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary;

namespace Terminal
{
    public partial class MainForm : Form
    {
        IServerProxy serverProxy;
        TechnicalBreakForm technicalBreakForm;
        ITerminal terminal;
        ActionInfo notSendedReplenish;

        public MainForm()
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

        private void ServerProxy_TechnicalBreak()
        {
            Task.Run(() => ShowTechnicalBreakForm());
        }

        private void ShowTechnicalBreakForm()
        {
            Invoke(new Action(() =>
            {
                if (technicalBreakForm == null || technicalBreakForm.IsDisposed)
                {
                    technicalBreakForm = new TechnicalBreakForm();
                }
                technicalBreakForm.ShowDialog(this);
            }));
        }

        private void ServerProxy_CancelTechnicalBreak()
        {
            if (technicalBreakForm != null)
            {
                Invoke(new Action(() =>
                {
                    technicalBreakForm.Close();
                    technicalBreakForm = null;
                }));
            }
        }

        private void BeginWindow_Shown(object sender, EventArgs e)
        {
            Refresh();
            try
            {
                _ = SettingsTerminal.Instance;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки настроек" + ex.Message);
            }

            notSendedReplenish = LoadNotSendedReplenish();

            if (!Connect())
            {
                Close();
                return;
            }

            try
            {
                if (SettingsTerminal.Instance.EmulateMode)
                {
                    terminal = EmulTerminal.RunEmulator();
                }
                else
                {
                    terminal = EmulTerminal.ConnectToDevice(SettingsTerminal.Instance.ComPort);
                }
            }
            catch (Exception exc)
            {
                using (var form = new TerminalErrorForm())
				{
                    form.ShowDialog();
				}
                Close();
                return;
            }

            PingTimer.Enabled = true;
        }

        private bool Connect(bool showErrorWindowFirst = false)
        {
            if (serverProxy != null)
            {
                serverProxy.TechnicalBreak -= ServerProxy_TechnicalBreak;
                serverProxy.CancelTechnicalBreak -= ServerProxy_CancelTechnicalBreak;
                serverProxy.NeedCashInfo -= ServerProxy_NeedCashInfo;
                serverProxy = null;
            }

            serverProxy = NetworkErrorForm.Reconnect(this, showErrorWindowFirst);
            if (serverProxy == null)
            {
                return false;
            }

            serverProxy.TechnicalBreak += ServerProxy_TechnicalBreak;
            serverProxy.CancelTechnicalBreak += ServerProxy_CancelTechnicalBreak;
            serverProxy.NeedCashInfo += ServerProxy_NeedCashInfo;

            if (notSendedReplenish != null)
			{
                serverProxy.Replenish(notSendedReplenish.PcName, notSendedReplenish.Cash);
                notSendedReplenish = null;
                SaveNotSendedReplenish(null);
			}

            return true;
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

        private async void KryptonButton1_Click(object sender, EventArgs e)
        {
            PingTimer.Enabled = false;

            int? PC = СhoosePCForm.GetPCName("ПОПОЛНЕНИЕ", this);
            if (PC != null)
            {
                int? cash = Intoduction.GetCashTerminal(PC, this, terminal);
                if (cash != null)
                {
                    var task = Replenish(PC.Value, cash.Value);

                    using (ConfirmationForm cf = new ConfirmationForm())
                    {
                        cf.ShowDialog(this);
                        
                        var result = await task;
                        if (result != null)
						{
                            notSendedReplenish = result;
                            if (!Connect(true))
							{
                                SaveNotSendedReplenish(notSendedReplenish);
                                Close();
                                return;
							}
						}
                    }
                }
            }

            PingTimer.Enabled = true;
        }

		private void SaveNotSendedReplenish(ActionInfo notSendedReplenish)
		{
            try
            {
                var fileName = ".\\notsended.log";
                if (notSendedReplenish == null)
                {
                    File.Delete(fileName);
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.UTF8))
                    {
                        sw.Write($"{notSendedReplenish.PcName}:{notSendedReplenish.Cash}");
                    }
                }
            }
            catch { }
		}

        private ActionInfo LoadNotSendedReplenish()
        {
            try
            {
                var fileName = ".\\notsended.log";
                var lines = File.ReadAllLines(fileName);
                if (lines.Length > 0)
				{
                    var line = lines[0].Split(':');
                    if (line.Length > 1 && int.TryParse(line[0], out int pcName) && int.TryParse(line[1], out int cash))
					{
                        return new ActionInfo { PcName = pcName, Cash = cash };
					}
				}
            }
            catch { }
            
            return null;
        }

        private Task<ActionInfo> Replenish(int pcName, int cash)
        {
            return Task.Run(() =>
            {
                try
                {
                    serverProxy.Replenish(pcName, cash);
                    return Task.FromResult<ActionInfo>(null);
                }
                catch
                {
                    return Task.FromResult<ActionInfo>(new ActionInfo() { PcName = pcName, Cash = cash });
                }
            });
        }

		private void KryptonButtonWithdrawal_Click(object sender, EventArgs e)
        {
            PingTimer.Enabled = false;

            int? PC = СhoosePCForm.GetPCName("СНЯТИЕ", this);
            if (PC != null)
            {
                try
                {
                    WaitingPaymentForm.SetCashAndPC(PC.Value, serverProxy, this, terminal);
                }
                catch
				{
                    if (!Connect(true))
                    {
                        Close();
                        return;
                    }
                }
            }

            PingTimer.Enabled = true;
        }

        private void PingTimer_Tick(object sender, EventArgs e)
        {
            PingTimer.Enabled = false;
            if (serverProxy != null)
            {
                try
                {
                    serverProxy.Ping();
                }
                catch
                {
                    if (!Connect(true))
                    {
                        Close();
                        return;
                    }
                }

                PingTimer.Enabled = true;
            }
        }
    }
}