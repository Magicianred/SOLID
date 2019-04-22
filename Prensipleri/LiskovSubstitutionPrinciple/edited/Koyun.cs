using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.edited
{
	public class Koyun : IOtlaBeslen
	{
		public bool otlaBeslenen()
		{
			Console.Write("otcul");
			return true;
		}
	}
}
