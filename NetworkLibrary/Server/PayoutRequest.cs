using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary.Server
{
	/// <summary>
	/// Запрос выдачи ДС
	/// </summary>
	public class PayoutRequest
	{
		/// <summary>
		/// Имя компа
		/// </summary>
		public int PCName { get; set; }
	}
}
