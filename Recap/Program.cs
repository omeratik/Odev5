using Recap.Abstract;
using Recap.Adapters;
using Recap.Concrete;
using Recap.Entities;

namespace Recap
{
    internal class Program
	{
		static void Main(string[] args)
		{
			User user1 = new User() { Id=1,FirstName="Ömer",LastName="Atik",DateOfBirth= new DateTime(2002,10,28),AccountBalance=500, NationalityId="23143556302"};
			User user2 = new User() { Id = 1, FirstName = "Ahmet", LastName = "Atik", DateOfBirth = new DateTime(2005, 5, 3), AccountBalance = 250, NationalityId="10777970530" };
		    Game game1 = new Game() { Id=1,Name="Minecraft",Price=150};
			Game game2 = new Game() { Id = 2, Name = "OutLast", Price = 500 };

					
			Discount discount1 = new Discount() { Id = 1, DiscountName = "Yeni kullanıcı indirimi", DiscountRatio = 10 };
			Discount discount2 = new Discount() { Id = 2, DiscountName = "Onaylı kullanıcı indirimi", DiscountRatio = 15 };

			GameManager gameManager = new GameManager();
			gameManager.OyunGuncelle(game1);

			IDiscountService indirimler = new DiscountManager();
			indirimler.IndirimEkle(discount1,game1);
			indirimler.IndirimKaldir(discount1);

			IDiscountService gameService = new DiscountManager();
			gameService.IndirimEkle(discount2,game1);

			UserManager userManager = new UserManager(new MernisServiceAdapter());
			userManager.KullaniciEkle(user2);
			userManager.KullaniciEkle(user1);
			
			










		}

	}
}