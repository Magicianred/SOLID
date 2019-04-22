using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.edited
{
	public class Fan : ISwitchable
	{
		public void turnOn()
		{
			Console.Write("fan:on");
		}

		public void turnOff()
		{
			Console.Write("fan:off");
		}
	}
}
