using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
	public class ChannelInfo
	{
		public int Value;
		public byte Channel;
		public string Currency;
		public int Level;
		public bool Recycling;

		public ChannelInfo()
		{
			Value = 0;
			Channel = 0;
			Currency = "";
			Level = 0;
			Recycling = false;
		}
	}
}
