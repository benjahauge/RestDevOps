using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestDevOps.Models
{
	public class Game
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Publisher { get; set; }
		public double Price { get; set; }
	}
}
