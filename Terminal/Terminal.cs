using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
	/// <summary>
	/// Класс работы с терминалом
	/// </summary>
	public class Terminal
	{
		private static int idNext = 0;
		private int id;

		private Terminal() { }

		public event Action<int> ReceivedCash;

		public static Terminal ConnectToDevice()
		{
			var terminal = new Terminal();
			terminal.id = idNext++;
			return terminal;
		}


		private bool canPayout = true;
		/// <summary>
		/// Выдать указанную сумму
		/// </summary>
		/// <param name="quantity"></param>
		public bool Payout(int quantity, out string log)
		{
			log = canPayout ? null : "Не достаточно средств для выплаты";
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
			if (MessageBox.Show($"Хвататет средтств для выплаты {quantity}", id.ToString(), MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				canPayout = true;
			}
			else
			{
				canPayout = false;
			}
			return true;
		}

		/// <summary>
		/// Включить приемник купюр
		/// </summary>
		public bool EnablePayout(out string log)
		{
			log = null;
			return true;
		}

		/// <summary>
		/// Выключить приемник купюр
		/// </summary>
		public bool DisablePayout(out string log)
		{
			log = null;
			return true;
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
