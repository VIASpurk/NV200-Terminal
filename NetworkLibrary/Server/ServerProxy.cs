using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyan.Communication;

namespace NetworkLibrary.Server
{
	internal class ServerProxy : IServerProxy
	{
		public event Action TechnicalBreak;
		public event Action CancelTechnicalBreak;
		public event Action<PayoutData> Payment;
		public event Action NeedCashInfo;

		public event Action<ReplenishmentData> ReplenishmentRequestEvent;
		public event Action<PayoutRequest> PayoutRequestEvent;
		public event Action<PayoutResult> PayoutResultEvent;
		public event Action<CashInfo[]> NeedCashInfoResultEvent;

		public void PayoutRequest(int pcName)
		{
			Task.Run(() => PayoutRequestEvent?.Invoke(new Server.PayoutRequest() { PCName = pcName }));
		}
		public void Replenish(int pcName, int quantity)
		{
			Task.Run(() => ReplenishmentRequestEvent?.Invoke(new ReplenishmentData() { PCName = pcName, Quantity = quantity }));
		}
		public void PayoutResult(PayoutResult request)
		{
			Task.Run(() => PayoutResultEvent?.Invoke(request));
		}
		public void NeedCashInfoRequest()
		{
			Task.Run(() => NeedCashInfo?.Invoke());
		}

		public void SetTechnicalBreakMode()
		{
			TechnicalBreak?.Invoke();
		}
		public void SetWorkingMode()
		{
			CancelTechnicalBreak?.Invoke();
		}
		public void Pay(int pcName, int quantity)
		{
			var args = new PayoutData()
			{
				PCName = pcName,
				Quantity = quantity,
			};
			Payment?.Invoke(args);
		}
		public void SendCashInfo(CashInfo[] data)
		{
			NeedCashInfoResultEvent?.Invoke(data);
		}

		public DateTime Ping()
		{
			return DateTime.Now;
		}
	}
}
