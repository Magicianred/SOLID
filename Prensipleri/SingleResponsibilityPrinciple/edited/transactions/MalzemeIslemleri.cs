using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.SingleResponsibilityPrinciple.edited.transactions
{
	public class MalzemeIslemleri : IMalzemeIslemleri
	{
		List<String> maList;

		public void malzemeCikar()
		{
			throw new NotImplementedException();
		}

		public void malzemeEkle()
		{
			throw new NotImplementedException();
		}

		public List<string> malzemeListesi()
		{
			return maList;
		}
	}
}
