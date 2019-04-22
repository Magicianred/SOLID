using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.edited
{
	public class Dikdortgen : ISekil
	{
		public int yukseklik;
		public int genislik;

		public double hesaplaAlan()
		{
			return yukseklik * genislik;
		}
	}
}
