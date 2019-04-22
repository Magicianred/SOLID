using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.DependencyInversionPrinciple.edited
{
	public interface ISwitch
	{
		bool isOn();

		void press();
	}
}
