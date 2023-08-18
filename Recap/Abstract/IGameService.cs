using Recap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Abstract
{
	public interface IGameService
	{
		void OyunEkle(Game game);
		void OyunKaldir(Game game);
		void OyunGuncelle(Game game);
	}
}
