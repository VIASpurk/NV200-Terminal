using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkLibrary
{
	/// <summary>
	/// Объект взаимодействия с сервером
	/// </summary>
	public interface IServerProxy
	{
		/// <summary>
		/// Установить технический перерыв
		/// </summary>
		event Action TechnicalBreak;

		/// <summary>
		/// Отменить перерыв, переход в рабочий режим
		/// </summary>
		event Action CancelTechnicalBreak;

		/// <summary>
		/// Выдать ДС.
		/// </summary>
		event Action<PayoutData> Payment;
		
		/// <summary>
		/// Передать инфо о наличии ДС к выдаче
		/// </summary>
		event Action NeedCashInfo;

		/// <summary>
		/// Сообщение о пополнении счета
		/// </summary>
		/// <param name="pcName"></param>
		/// <param name="quantity"></param>
		void Replenish(int pcName, int quantity);

		/// <summary>
		/// Запрос выдачи ДС
		/// </summary>
		/// <param name="pcName"></param>
		void PayoutRequest(int pcName);

		/// <summary>
		/// Ответ на запрос выдачи ДС
		/// </summary>
		/// <param name="result"></param>
		void PayoutResult(PayoutResult result);

		/// <summary>
		/// Передать информацию о ДС к выдаче
		/// </summary>
		/// <param name="data"></param>
		void SendCashInfo(CashInfo[] data);
	}
}
