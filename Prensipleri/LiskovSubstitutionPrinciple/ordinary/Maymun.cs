using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public class Maymun : IBeslenme
	{
		public bool etleBeslen()
		{
			Console.Write("maymun etle de beslenir");
			return true;
		}

		public bool otlaBeslen()
		{
			Console.Write("otla da beslenir");
			return true;
		}
	}
}
