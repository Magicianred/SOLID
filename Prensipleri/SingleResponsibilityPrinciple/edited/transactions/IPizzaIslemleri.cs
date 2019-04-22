using Prensipleri.SingleResponsibilityPrinciple.edited.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.SingleResponsibilityPrinciple.edited.transactions
{
	public interface IPizzaIslemleri // Pizza Processing
	{
		void pisir(int zaman); // cook it : how time

		void fiyatHesapla(); // calculate price

		void hamurAc(Pizza pizza);
	}
}
