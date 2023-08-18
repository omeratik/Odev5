using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Abstract
{
	public interface IUserService
	{
		void KullaniciEkle(User user);
		void KullaniciKaldir(User user);
		void KullaniciGuncelle(User user);
	}
}
