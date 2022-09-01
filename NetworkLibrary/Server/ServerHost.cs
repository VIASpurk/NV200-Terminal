using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyan.Communication;

namespace NetworkLibrary.Server
{
	/// <summary>
	/// Сервер для работы с терминалом
	/// </summary>
	public class ServerHost : IDisposable
	{
		private ServerProxy proxy;
		private ZyanComponentHost Host { get; set; }

		/// <summary>
		/// Сообщение о получении ДС
		/// </summary>
		public event Action<ReplenishmentData> ReplenishmentRequest
		{
			add { proxy.ReplenishmentRequestEvent += value; }
			remove { proxy.ReplenishmentRequestEvent -= value; }
		}
		/// <summary>
		/// Запрос на выдачу ДС
		/// </summary>
		public event Action<PayoutRequest> PayoutRequest
		{
			add { proxy.PayoutRequestEvent += value; }
			remove { proxy.PayoutRequestEvent -= value; }
		}
		/// <summary>
		/// Результат выдачи ДС
		/// </summary>
		public event Action<PayoutResult> PayoutResult
		{
			add { proxy.PayoutResultEvent += value; }
			remove { proxy.PayoutResultEvent -= value; }
		}
		/// <summary>
		/// Данные о ДС для выдачи
		/// </summary>
		public event Action<CashInfo[]> NeedCashInfoResult
		{
			add { proxy.NeedCashInfoResultEvent += value; }
			remove { proxy.NeedCashInfoResultEvent -= value; }
		}

		private ServerHost() { }

		/// <summary>
		/// Запуск сервера
		/// </summary>
		/// <param name="hostName"></param>
		/// <param name="portName"></param>
		/// <returns></returns>
		public static ServerHost StartServer(string hostName = "localhost", int portName = 8080)
		{
			var server = new ServerHost();
			server.proxy = new ServerProxy();
			server.Host = new ZyanComponentHost("ServerHost", 8080);
			server.Host.RegisterComponent<IServerProxy, ServerProxy>(server.proxy);
			return server;
		}

		void IDisposable.Dispose()
		{
			Host?.Dispose();
		}

		/// <summary>
		/// Установить тех. перерыв
		/// </summary>
		public void SetTechnicalBreakMode()
		{
			proxy.SetTechnicalBreakMode();
		}
		/// <summary>
		/// Тех. перерыв закончен
		/// </summary>
		public void SetWorkingMode()
		{
			proxy.SetWorkingMode();
		}
		/// <summary>
		/// Выдать ДС
		/// </summary>
		/// <param name="pcName"></param>
		/// <param name="quantity"></param>
		public void Pay(int pcName, int quantity)
		{
			proxy.Pay(pcName, quantity);
		}
		/// <summary>
		/// Запрос данных о ДС для выдачи
		/// </summary>
		public void NeedCashInfo()
		{
			proxy.NeedCashInfoRequest();
		}
	}
}
