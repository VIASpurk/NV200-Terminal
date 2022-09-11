using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary.Classes;

namespace TerminalLibrary
{
	/// <summary>
	/// Класс работы с терминалом
	/// </summary>
	public class Terminal : IDisposable, ITerminal
	{
		private string comport;
		private CPayout payoutModule;
		private bool disposing;
		private volatile bool connected = false;
		private char[] currency = new char[] { 'R', 'U', 'B' };
		private readonly int multiplier = 100;

		// acccess to hold number
		public int HoldNumber
		{
			get { return payoutModule.HoldNumber; }
			set { payoutModule.HoldNumber = value; }

		}

		private Terminal() { }

		/// <summary>
		/// Получена сумма от пользователя
		/// </summary>
		public event Action<int> ReceivedCash; 
		public event Action<string> PoolLog;
		/// <summary>
		/// Выдана сумма пользователю
		/// </summary>
		public event Action<int> PayoutCash;
		/// <summary>
		/// Терминал читает банкноту
		/// </summary>
		public event Action ReadingNote;

		public static Terminal ConnectToDevice(string comport)
		{
			var terminal = new Terminal
			{
				comport = comport
			};
			terminal.Connect();
			return terminal;
		}

		/// <summary>
		/// Выдать указанную сумму
		/// </summary>
		/// <param name="quantity"></param>
		public bool Payout(int quantity, out string log)
		{
			var amount = quantity * multiplier;
			var result = payoutModule.PayoutAmount(amount, currency, false, out log);

			return result;
		}

		/// <summary>
		/// Имеется ли сумма в наличии для выдачи
		/// </summary>
		/// <param name="quantity"></param>
		/// <returns></returns>
		public bool CanPayout(int quantity, out string log)
		{
			return payoutModule.PayoutAmount(quantity * multiplier, currency, true, out log);
		}

		/// <summary>
		/// Включить приемник купюр
		/// </summary>
		public bool EnablePayout(out string log)
		{
			return payoutModule.EnablePayout(out log);
		}

		/// <summary>
		/// Выключить приемник купюр
		/// </summary>
		public bool DisablePayout(out string log)
		{
			return payoutModule.DisablePayout(out log);
		}

		public void EnableValidator(out string log)
		{
			payoutModule.EnableValidator(out log);
		}
		public void DisableValidator(out string log)
		{
			payoutModule.DisableValidator(out log);
		}

		public ChannelInfo[] GetInfo()
		{
			var list = new List<ChannelInfo>();
			foreach (ChannelData d in payoutModule.UnitDataList)
			{
				list.Add(new ChannelInfo()
				{
					Value = d.Value / multiplier,
					Level = d.Level,
					Channel = d.Channel,
					Currency = $"{d.Currency[0]}{d.Currency[1]}{d.Currency[2]}",
					Recycling = d.Recycling,
				});
			}
			return list.ToArray();
		}

		public bool ChangeNoteRoute(bool toCashbox, out string log)
		{
			StringBuilder sb = new StringBuilder();
			foreach(var channel in payoutModule.UnitDataList)
			{
				if (payoutModule.ChangeNoteRoute(channel.Value, channel.Currency, toCashbox, out string error) == false)
				{
					sb.Append(error + Environment.NewLine);
				}
				else
				{
					payoutModule.IsNoteRecycling(channel.Value, channel.Currency, ref channel.Recycling, out log);
				}
			}
			log = sb.ToString();
			return string.IsNullOrEmpty(log);
		}

		private void Connect()
		{
			var errorText = "Не удалось подключиться к терминалу:";

			payoutModule = new CPayout();

			// Setup connection info
			payoutModule.CommandStructure.ComPort = comport;
			payoutModule.CommandStructure.SSPAddress = 0;
			payoutModule.CommandStructure.BaudRate = 9600;
			payoutModule.CommandStructure.Timeout = 1000;
			payoutModule.CommandStructure.RetryLevel = 3;

			// turn encryption off for first stage
			payoutModule.CommandStructure.EncryptionStatus = false;

			// Open port first
			if (payoutModule.OpenPort() == false)
			{
				throw new ApplicationException($"{errorText} порт {comport} не доступен");
			}

			// if the key negotiation is successful then set the rest up
			if (payoutModule.NegotiateKeys(out string error))
			{
				payoutModule.CommandStructure.EncryptionStatus = true; // now encrypting

				// find the max protocol version this validator supports
				try
				{
					SetMaxPayoutProtocolVersion();
				}
				catch (Exception exc)
				{
					throw new ApplicationException($"{errorText} {exc.Message}");
				}

				// get info from the validator and store useful vars
				if (payoutModule.PayoutSetupRequest(out error) == false)
				{
					throw new ApplicationException($"{errorText} {error}");
				};

				// check the right unit is connected
				if (!IsValidatorSupported(payoutModule.UnitType))
				{
					throw new ApplicationException($"{errorText} Unsupported type shown by SMART Payout, this SDK supports the SMART Payout only");
				}

				// inhibits, this sets which channels can receive notes
				payoutModule.SetInhibits(out string tmpLog);

				payoutModule.EnablePayout(out tmpLog);

				ChangeNoteRoute(false, out tmpLog);

				payoutModule.DispensedNote += DispensedNote;
				payoutModule.StoredNote += StoredNote;
				payoutModule.ReadingNote += ReadingNewNote;
			}
			else
			{
				throw new ApplicationException($"{errorText} {error}");
			}

			connected = true;

			Task.Run(MainLoop);
		}

		private void DispensedNote(int obj)
		{
			Task.Run(new Action(() => PayoutCash?.Invoke(obj / multiplier)));
		}
		private void StoredNote(int obj)
		{
			Task.Run(new Action(() => ReceivedCash?.Invoke(obj / multiplier)));
		}
		private void ReadingNewNote()
		{
			Task.Run(new Action(() => ReadingNote?.Invoke()));
		}

		private void SetMaxPayoutProtocolVersion()
		{
			// not dealing with protocol under level 6
			// attempt to set in validator
			byte b = 0x06;
			string log;
			while (true)
			{
				payoutModule.SetProtocolVersion(b, out log);
				// If it fails then it can't be set so fall back to previous iteration and return it
				if (payoutModule.CommandStructure.ResponseData[0] == CCommands.SSP_RESPONSE_FAIL)
				{
					--b;
					break;
				}

				b++;

				// If the protocol version 'runs away' because of a drop in comms. Return the default value.
				if (b > 20)
				{
					b = 0x06;
					break;
				}
			}
			if (b >= 6)
			{
				payoutModule.SetProtocolVersion(b, out log);
			}
			else
			{
				throw new NotSupportedException("This program does not support units under protocol 6!");
			}
		}

		// This function checks whether the type of validator is supported by this program.
		private bool IsValidatorSupported(char type)
		{
			if (type == (char)0x06) // SMART Payout
				return true;
			return false;
		}

		private void MainLoop()
		{
			while (connected)
			{
				//do Poll

				int timer = 0;
				while (timer < 250)
				{
					timer++;
					if (disposing)
					{
						connected = false;
					}
					if (!connected)
					{
						break;
					}
					Thread.Sleep(1);
				}
				if (payoutModule.DoPoll(out string log))
				{
				}

				if (!string.IsNullOrEmpty(log))
				{
					PoolLog?.Invoke(log);
				}
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposing)
			{
				if (disposing)
				{
					// TODO: освободить управляемое состояние (управляемые объекты)
					LibraryHandler.ClosePort();
					connected = false;
				}

				// TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
				// TODO: установить значение NULL для больших полей
				this.disposing = true;
			}
		}

		void IDisposable.Dispose()
		{
			// Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
