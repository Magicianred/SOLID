using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public class Aslan : IBeslenme
	{
		public bool etleBeslen()
		{
			Console.Write("Aslan etle beslenir");
			return true;
		}

		public bool otlaBeslen()
		{
			Console.Write("otla beslenmez!!!");
			return false;
		}

	}
}
