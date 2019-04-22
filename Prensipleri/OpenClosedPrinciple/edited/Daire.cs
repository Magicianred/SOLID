using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.edited
{
	public class Daire : ISekil
	{
		public double yaricap;

		public double hesaplaAlan()
		{
			// TODO Auto-generated method stub
			return (Math.PI) * (Math.Pow(yaricap, 2));
		}
	}
}
