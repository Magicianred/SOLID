using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prensipleri.SingleResponsibilityPrinciple.ordinary
{
	public class Pizza
	{
		public string cesit; // type
		public string ebat; // size
		public string fiyat; // price
		List<string> maList = new List<string>();

		public string getCesit() {
			return cesit;
		}
		public void setCesit(string cesit) {
			this.cesit = cesit;
		}

		public string getEbat() {
			return ebat;
		}
		public void setEbat(string ebat) {
			this.ebat = ebat;
		}

		public string getFiyat() {
			return fiyat;
		}
		public void setFiyat(string fiyat) {
			this.fiyat = fiyat;
		}

		public void malzemeEkle()
		{ // insert ingredient
			throw new NotImplementedException();
		}
		public void malzemeCikar()
		{ // remove ingredient
			throw new NotImplementedException();
		}

		public List<string> malzemeListesi()
		{ // list of ingredients
			return maList;
		}

		public void pisir(int zaman)
		{ // cook it : how time
			throw new NotImplementedException();
		}

		public void hamurAc(string ebat)
		{
			throw new NotImplementedException();
		}

		public void fiyatHesapla()
		{ // calculate price
			throw new NotImplementedException();
		}

		public List<string> getMaList() {
			return maList;
		}

		public void setMaList(List<string> maList) {
			this.maList = maList;
		}
	}
}
