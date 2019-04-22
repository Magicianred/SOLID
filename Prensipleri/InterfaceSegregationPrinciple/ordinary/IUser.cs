using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.InterfaceSegregationPrinciple.ordinary
{
	public interface IUser
	{
		void update();

		void create();

		void delete();
	}
}
