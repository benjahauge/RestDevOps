using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestDevOps.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestDevOps.Models;

namespace RestDevOps.Managers.Tests
{
	[TestClass()]
	public class GameManagerTests
	{
		private GameManager _manager = new GameManager();
		//private Game newGame = new Game() {Name = "Far Cry 6", Publisher = "Ubisoft", Price = 450};
		[TestMethod()]
		public void GetAllTest()
		{
			int expectedResult = 2;
			
			Assert.AreEqual(expectedResult, _manager.GetAll().Count);
		}

		//[TestMethod()]
		//public void GetByIdTest()
		//{
		//	Assert.Fail();
		//}
	}
}