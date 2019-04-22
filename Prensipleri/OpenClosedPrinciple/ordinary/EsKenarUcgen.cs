using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.ordinary
{
	public class EsKenarUcgen // Equilateral triangle
	{
		public int birinciKenar; // First Edge

		public void setBirinciKenar(int birinciKenar)
		{
			this.birinciKenar = birinciKenar;
		}

		public int getBirinciKenar()
		{
			return birinciKenar;
		}
	}
}
