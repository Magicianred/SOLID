using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.ordinary
{
	public class AlanHesapla // Calculate Area
	{
		public int dikdortAlan(Dikdortgen dikdortgen) // Rectangular Area
		{
			return dikdortgen.genislik * dikdortgen.yukseklik;
		}

		public int ucgenAlan(EsKenarUcgen ucgen) // area
		{
			return (int)(ucgen.birinciKenar * ucgen.birinciKenar * (Math.Pow(ucgen.birinciKenar, (1 / 3))) / 4);
		}

		public double daireAlan(Daire daire) // circle area
		{
			return (Math.PI) * (Math.Pow(daire.yaricap, 2));
		}
	}
}
}
