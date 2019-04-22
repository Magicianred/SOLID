using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.ordinary
{
	public class ElectricPower
	{
		public LightBulb bulb;
		public bool on;

		public ElectricPower(LightBulb bulb)
		{
			this.bulb = bulb;
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
				bulb.turnOff();
				this.on = false;

			}
			else
			{
				bulb.turnOn();
				this.on = true;
			}
		}
	}
}
