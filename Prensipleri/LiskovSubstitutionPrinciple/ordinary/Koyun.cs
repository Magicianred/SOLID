using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public class Koyun : IBeslenme
	{
		public bool etleBeslen()
		{
			Console.Write("et yemez ");
			return false;
		}

		public bool otlaBeslen()
		{
			Console.Write("otla beslenir");
			return true;
		}
	}
}
