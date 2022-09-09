using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary;

namespace TestTerminal
{
	public partial class Form1 : Form
	{
		private Terminal terminal;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ComPortComboBox.Items.AddRange(SerialPort.GetPortNames());
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			try
			{
				terminal = Terminal.ConnectToDevice(ComPortComboBox.SelectedItem.ToString());
				terminal.ReceivedCash += Terminal_ReceivedCash;
				terminal.PoolLog += Terminal_PoolLog;
				terminal.PayoutCash += Terminal_PayoutCash;
			}catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
				ActionTextBox.AppendText(exc.Message + Environment.NewLine);
			}
		}

		private void Terminal_PayoutCash(int obj)
		{
			this.Invoke(new Action(() => ActionTextBox.AppendText($"Выдано {obj}" + Environment.NewLine)));
		}

		private void Terminal_PoolLog(string obj)
		{
			Task.Run(new Action( () => this.Invoke(new Action(() => PollTextBox.AppendText(obj + Environment.NewLine)))));
		}

		private void Terminal_ReceivedCash(int obj)
		{
			this.Invoke(new Action(() => ActionTextBox.AppendText($"Внесено {obj}" + Environment.NewLine)));
		}

		private void buttonEnableValidator_Click(object sender, EventArgs e)
		{
			string result;
			terminal.EnableValidator(out result);
			if (!string.IsNullOrEmpty(result))
			{
				ActionTextBox.AppendText(result + Environment.NewLine);
			}
		}

		private void buttonGetInfo_Click(object sender, EventArgs e)
		{
			var info = terminal.GetInfo();
			foreach(var ch in info)
			{
				ActionTextBox.AppendText($"{ch.Channel}. {ch.Currency} {ch.Value}, {ch.Level} шт. (Recycling - {ch.Recycling})" + Environment.NewLine);
			}
		}

		private void buttonEnablePayout_Click(object sender, EventArgs e)
		{
			terminal.EnablePayout(out string log);
			if (!string.IsNullOrEmpty(log))
			{
				ActionTextBox.AppendText(log + Environment.NewLine);
			}
		}

		private void buttonDisablePayout_Click(object sender, EventArgs e)
		{
			terminal.DisablePayout(out string log);
			if (!string.IsNullOrEmpty(log))
			{
				ActionTextBox.AppendText(log + Environment.NewLine);
			}
		}

		private void buttonDisableValidator_Click(object sender, EventArgs e)
		{
			terminal.DisableValidator(out string log);
			if (!string.IsNullOrEmpty(log))
			{
				ActionTextBox.AppendText(log + Environment.NewLine);
			}
		}

		private void ToCashboxcheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (terminal.ChangeNoteRoute(ToCashboxcheckBox.Checked, out string log) == false)
			{
				ActionTextBox.AppendText(log + Environment.NewLine);
			}
		}

		private void buttonCanPayout_Click(object sender, EventArgs e)
		{
			var res = terminal.CanPayout((int)numericUpDown1.Value, out string log);
			ActionTextBox.AppendText($"CanPayout: {res} {log}" + Environment.NewLine);
		}

		private void buttonPayout_Click(object sender, EventArgs e)
		{
			var res = terminal.Payout((int)numericUpDown1.Value, out string log);
			ActionTextBox.AppendText($"Payout: {res} {log}" + Environment.NewLine);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				terminal.HoldNumber = 5;
			}
			else
			{
				terminal.HoldNumber = 0;
			}
		}

		private void SaveLogButton_Click(object sender, EventArgs e)
		{
			var date = $"{DateTime.Now:ddMMyyy_HHmm}";
			File.WriteAllText($"PolLog_{date}.txt", PollTextBox.Text, Encoding.UTF8);
			File.WriteAllText($"ActionLog_{date}.txt", ActionTextBox.Text, Encoding.UTF8);
		}

		public class CashInfo
		{
			/// <summary>
			/// Значение купюры
			/// </summary>
			public int Value { get; set; }

			/// <summary>
			/// Количество купюр
			/// </summary>
			public int Count { get; set; }
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var amount = 750;
			var availableCash = new CashInfo[]
			{
				new CashInfo() { Value = 50, Count = 1 },
				new CashInfo() { Value = 100, Count = 2 },
				new CashInfo() { Value = 200, Count = 3 },
				new CashInfo() { Value = 500, Count = 0 },
			};


			var cashbox = availableCash.OrderByDescending(x => x.Value);
			var amountTmp = amount;
			foreach (var cashItem in cashbox)
			{
				while (amountTmp >= cashItem.Value)
				{
					if (cashItem.Count > 0)
					{
						amountTmp -= cashItem.Value;
						cashItem.Count--;
					}
					else
					{
						break;
					}
				}
			}
			if (amountTmp > 0)
			{
				MessageBox.Show("Недостаточно купюр для выдачи");
			}
		}
	}
}
