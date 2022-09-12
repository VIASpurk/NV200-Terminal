using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerminalLibrary;

namespace Terminal
{
	/// <summary>
	/// Класс работы с терминалом
	/// </summary>
	public class EmulTerminal : TerminalLibrary.ITerminal
	{
		private static int idNext = 0;
		private int id;

		private EmulTerminal() { }

		public event Action<int> ReceivedCash;
		public event Action<int> PayoutCash;
		/// <summary>
		/// Терминал читает банкноту
		/// </summary>
		public event Action ReadingNote;
		public event Action StackingNote;
		public event Action RejectingNote;

		public static ITerminal RunEmulator()
		{
			var terminal = new EmulTerminal
			{
				id = idNext++
			};
			return terminal;
		}

		public static ITerminal ConnectToDevice(string comport)
		{
			return TerminalLibrary.Terminal.ConnectToDevice(comport);
		}


		private bool canPayout = true;
		/// <summary>
		/// Выдать указанную сумму
		/// </summary>
		/// <param name="quantity"></param>
		public bool Payout(int quantity, out string log)
		{
			log = canPayout ? null : "Недостаточно средств для выплаты";

			if (canPayout)
			{
				Task.Run( async () => 
				{
					await Task.Delay(5000);
					PayoutCash?.Invoke(quantity); 
				});
			}
			return canPayout;
		}

		/// <summary>
		/// Имеется ли сумма в наличии для выдачи
		/// </summary>
		/// <param name="quantity"></param>
		/// <returns></returns>
		public bool CanPayout(int quantity, out string log)
		{
			log = null;
			var openedForm = Application.OpenForms.OfType<Form>().FirstOrDefault(x => x.TopLevel);
			if (openedForm != null)
			{
				openedForm.Invoke(new Action(() =>
				{
					if (MessageBox.Show(openedForm, $"Хвататет средтств для выплаты {quantity}", id.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						canPayout = true;
					}
					else
					{
						canPayout = false;
					};
				}));
			}
			return true;
		}

		/// <summary>
		/// Включить приемник купюр
		/// </summary>
		public void EnableValidator(out string log)
		{
			log = null;
			Task.Run( async () => 
			{
				await Task.Delay(1000);
				ReadingNote?.Invoke();
				await Task.Delay(2000);
				StackingNote?.Invoke(); 
				await Task.Delay(4000); 
				ReceivedCash?.Invoke(500);
				await Task.Delay(1000);
				StackingNote?.Invoke();
				await Task.Delay(3000);
				ReceivedCash?.Invoke(200);
			});
		}

		/// <summary>
		/// Выключить приемник купюр
		/// </summary>
		public void DisableValidator(out string log)
		{
			log = null;
		}

		public ChannelInfo[] GetInfo()
		{
			return new ChannelInfo[] 
			{
				new ChannelInfo() { Value = 50, Level = 4, },
				new ChannelInfo() { Value = 100, Level = 1, },
				new ChannelInfo() { Value = 500, Level = 6, },
			};
		}
	}
}
