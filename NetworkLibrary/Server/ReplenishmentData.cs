using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Server
{
	/// <summary>
	/// Данные о пополнении
	/// </summary>
	public class ReplenishmentData
	{
		/// <summary>
		/// Имя компа
		/// </summary>
		public int PCName { get; set; }
		/// <summary>
		/// Сумма
		/// </summary>
		public int Quantity { get; set; }
	}
}
