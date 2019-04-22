using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.edited
{
	public class EsKenarUcgen : ISekil
	{
		public int kenar; // edge

		public double hesaplaAlan()
		{
			// TODO Auto-generated method stub
			return (kenar * kenar * (Math.Pow(kenar, (1 / 3))) / 4);
		}
	}
}
