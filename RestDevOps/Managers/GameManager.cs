using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestDevOps.Models;

namespace RestDevOps.Managers
{
	public class GameManager
	{
		private static int _nextId = 1;
		private static readonly List<Game> data = new List<Game>()
		{
			new Game() {ID = _nextId++, Name = "Red dead redemption 2", Publisher = "Rockstar", Price = 350},
			new Game() {ID = _nextId++, Name = "Eastward", Publisher = "Chucklefish", Price = 150}
		};

		public List<Game> GetAll()
		{
			return data;
		}

		public Game GetById(int id)
		{
			return data.FirstOrDefault(game => game.ID == id);
		}
	}
}
