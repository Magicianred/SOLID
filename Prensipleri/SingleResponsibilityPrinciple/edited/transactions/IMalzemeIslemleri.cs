using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.SingleResponsibilityPrinciple.edited.transactions
{
	public interface IMalzemeIslemleri // Material Operations
	{
		void malzemeEkle(); // insert ingredient

		void malzemeCikar(); // remove ingredient

		List<String> malzemeListesi(); // list of ingredients
	}
}
