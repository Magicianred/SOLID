using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.edited
{
	public class Aslan : IEtleBeslen
	{
		public bool etleBeslenen()
		{
			Console.Write("et�il");
			return true;
		}
	}
}
