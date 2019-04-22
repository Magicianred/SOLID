using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public interface IBeslenme
	{
		bool etleBeslen();

		bool otlaBeslen();
	}
}
