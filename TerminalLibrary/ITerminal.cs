using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalLibrary
{
	public interface ITerminal
	{

		event Action<int> ReceivedCash;
		event Action<int> PayoutCash;

		bool Payout(int quantity, out string log);
		bool CanPayout(int quantity, out string log);

		void EnableValidator(out string log);
		void DisableValidator(out string log);

		ChannelInfo[] GetInfo();
	}
}
