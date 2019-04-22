using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.edited
{
	public class Hayvan
	{
		List<IEtleBeslen> etcil;
		List<IOtlaBeslen> otcul;

		public Hayvan(List<IEtleBeslen> etcil, List<IOtlaBeslen> otcul)
		{
			this.etcil = etcil;
			this.otcul = otcul;
		}

		public void etleBeslen()
		{
			foreach (IEtleBeslen iEtleBeslen in etcil)
			{
				iEtleBeslen.etleBeslenen();
			}
		}

		public void otlaBeslen()
		{
			foreach (IOtlaBeslen iOtlaBeslen in otcul)
			{
				iOtlaBeslen.otlaBeslenen();
			}
		}
	}
}
}
