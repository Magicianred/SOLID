using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.ordinary
{
	public class LightBulb
	{
		public void turnOn()
		{
			Console.Write("turned on..");
		}

		public void turnOff()
		{
			Console.Write("turned off..");
		}
	}
}
