using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestDevOps.Managers;
using RestDevOps.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestDevOps.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GamesController : ControllerBase
	{
		private readonly GameManager _manager = new GameManager();

		// GET: api/<GamesController>
		[HttpGet]
		public IEnumerable<Game> Get()
		{
			return _manager.GetAll();
		}

		// GET api/<GamesController>/5
		[HttpGet("{id}")]
		public Game Get(int id)
		{
			return _manager.GetById(id);
		}

		// POST api/<GamesController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<GamesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<GamesController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
