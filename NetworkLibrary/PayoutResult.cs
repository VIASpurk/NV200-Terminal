using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyan.Communication.Delegates;

namespace NetworkLibrary
{
	/// <summary>
	/// Результат действия выдачи ДС
	/// </summary>
	[Serializable]
	public class PayoutResult
	{
		/// <summary>
		/// Номер компа
		/// </summary>
		public int PCName { get; set; }
		/// <summary>
		/// Сумма для выдачи
		/// </summary>
		public int Quantity { get; set; }
		/// <summary>
		/// Результат. true - ДС выданы, иначе false
		/// </summary>
		public bool OperationComplete { get; set; }
		/// <summary>
		/// Сообщение об ошибке выдаче
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
