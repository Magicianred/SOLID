using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public class Hindi : IBeslenme
	{
		public bool etleBeslen()
		{
			Console.Write("hindi etle de beslenir ");
			return true;
		}

		public bool otlaBeslen()
		{
			Console.Write("otla da beslenir");
			return true;
		}
	}
}
