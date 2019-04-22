using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.LiskovSubstitutionPrinciple.ordinary
{
	public class Hayvan
	{
		List<IBeslenme> hayvanlar;

		public Hayvan(List<IBeslenme> hayvanlar)
		{
			this.hayvanlar = hayvanlar;
		}

		public void etleBeslen()
		{
			foreach (IBeslenme iBeslenme in hayvanlar)
			{
				iBeslenme.etleBeslen();
			}
		}

		public void otlaBeslen()
		{
			foreach (IBeslenme iBeslenme in hayvanlar)
			{
				iBeslenme.otlaBeslen();
			}
		}
	}
}
