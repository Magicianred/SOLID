using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.InterfaceSegregationPrinciple.ordinary
{
	public class LowUser : IUser
	{
		public void update()
		{
			Console.Write("+");
		}

		public void create()
		{
			try
			{
				throw new Exception();
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
			}
		}

		public void delete()
		{
			try
			{
				throw new Exception();
			}
			catch (Exception e)
			{
				Console.Write(e.StackTrace);
			}
		}
	}
}
