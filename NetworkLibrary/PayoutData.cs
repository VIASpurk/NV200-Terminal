using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
	/// <summary>
	/// Параметры запроса для выдачи ДС
	/// </summary>
	[Serializable]
    public class PayoutData
    {
		/// <summary>
		/// Имя компа
		/// </summary>
		public int PCName { get; set; }
		/// <summary>
		/// Внесенная сумма
		/// </summary>
		public int Quantity { get; set; }
	}
}
