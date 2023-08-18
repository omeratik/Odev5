using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Abstract
{
	public interface IDiscountService
	{
		void IndirimEkle(Discount discount, Game game);
		void IndirimKaldir(Discount discount);
		void IndirimGuncelle(Discount discount);
	}
}
