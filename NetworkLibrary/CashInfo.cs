using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
	/// <summary>
	/// Данные о канале ДС к выплате
	/// </summary>
	[Serializable]
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
}
