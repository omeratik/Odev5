using Recap.Abstract;
using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Concrete
{
	public class UserManager :IUserService
	{
		private IUserCheckService _userCheckService;
		
		public UserManager(IUserCheckService userCheckService)
		{
			_userCheckService = userCheckService;
		}

		public void KullaniciEkle(User user)
		{
			if (_userCheckService.CheckIfRealPerson(user))
			{
                Console.WriteLine("Kullanıcı ekleme basarılı : " + user.FirstName + " " + user.Id + user.NationalityId);
            }
			else
			{
                Console.WriteLine("Ne yazıkki gerçek kullanıcı değilsiniz.");
            }
		}

		public void KullaniciGuncelle(User user)
		{
			Console.WriteLine("Kullanici guncellendi." + user.FirstName + " " + user.Id + user.NationalityId);
		}

		public void KullaniciKaldir(User user)
		{
			Console.WriteLine("Kullanici kaldırıldı." + user.FirstName + " " + user.Id + user.NationalityId);
		}
	}
}
