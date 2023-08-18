using Recap.Abstract;
using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Concrete
{
	public class GameManager : IGameService
	{
		public void OyunEkle(Game game)
		{
            Console.WriteLine("Oyun mağazaya eklendi . : " + game.Name + game.Id); 
		}
	
		public void OyunKaldir(Game game)
		{
			Console.WriteLine("Oyun mağazadan kaldırıldı. : " + game.Name + game.Id);
		}

		public void OyunGuncelle(Game game)
		{
			Console.WriteLine("Oyun güncellendi.  :" + game.Name + game.Id);
		}
	}
}
