using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalLibrary.Classes
{
	internal class ChannelData
	{
		/// <summary>
		/// Значение банкноты  1000 - это 10.00
		/// </summary>
		public int Value;
		/// <summary>
		/// Ячейка устройства
		/// </summary>
		public byte Channel;
		/// <summary>
		/// Валюта
		/// </summary>
		public char[] Currency;
		/// <summary>
		/// Количество банкнот
		/// </summary>
		public int Level;
		public bool Recycling;
		public ChannelData()
		{
			Value = 0;
			Channel = 0;
			Currency = new char[3];
			Level = 0;
			Recycling = false;
		}
	};
}
