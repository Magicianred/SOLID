﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.edited
{
	public class LightBulb : ISwitchable
	{
		public void turnOn()
		{
			Console.Write("lightbulb:on");
		}

		public void turnOff()
		{
			Console.Write("lightbulb:off");
		}
	}
}
