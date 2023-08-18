using Recap.Abstract;
using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Concrete
{
	public class DiscountManager : IDiscountService
	{

		public void IndirimEkle(Discount discount, Game game)
		{
			Console.WriteLine("İndirim oyuna uygulandı . : " + discount.DiscountName + discount.DiscountRatio + game.Name);
		}

		public void IndirimKaldir(Discount discount)
		{
			Console.WriteLine("İndirim kaldırıldı. : " + discount.DiscountName + discount.DiscountRatio);
		}

		public void IndirimGuncelle(Discount discount)
		{
			Console.WriteLine("İndirim oranı güncellendi. : " + discount.DiscountName + discount.DiscountRatio);
		}
	}
}