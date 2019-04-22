using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.OpenClosedPrinciple.ordinary
{
	public class Dikdortgen // Rectangle
	{
		public int yukseklik; // height
		public int genislik; // width

		public void setGenislik(int genislik)
		{
			this.genislik = genislik;
		}

		public void setYukseklik(int yukseklik)
		{
			this.yukseklik = yukseklik;
		}

		public int getGenislik()
		{
			return genislik;
		}

		public int getYukseklik()
		{
			return yukseklik;
		}
	}
}
