using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.edited
{
	public class ElectricPower : ISwitch
	{
		public ISwitchable client;
		public bool on;

		public ElectricPower(ISwitchable client)
		{
			this.client = client;
			this.on = false;
		}

		public bool isOn()
		{
			return this.on;
		}

		public void press()
		{
			bool checkOn = isOn();
			if (checkOn)
			{
				client.turnOff();
				this.on = false;
			}
			else
			{
			}
			client.turnOn();
			this.on = true;

		}
	}
}