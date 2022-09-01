using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyan.Communication;

namespace NetworkLibrary.Client
{
	/// <summary>
	/// Класс подключения к серверу
	/// </summary>
	public static class ClientConnection
	{
		/// <summary>
		/// Подключиться к серверу
		/// </summary>
		/// <param name="hostName"></param>
		/// <param name="portName"></param>
		/// <returns></returns>
		public static IServerProxy ConnectToServer(string hostName = "localhost", int portName = 8080)
		{
			var connection = new ZyanConnection($"tcp://{hostName}:{portName}/ServerHost");
			return connection.CreateProxy<IServerProxy>();
		}
	}
}
