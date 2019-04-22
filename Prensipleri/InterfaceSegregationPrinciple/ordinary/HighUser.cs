using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.InterfaceSegregationPrinciple.ordinary
{
	public class HighUser : IUser
	{
		public void update()
		{
			Console.Write("+");
		}

		public void create()
		{
			Console.Write("+");
		}

		public void delete()
		{
			Console.Write("+");
		}
	}
}
