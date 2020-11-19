using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.Domain.Data;
using RepositoryPatternDemo.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryPatternDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : ControllerBase
    {
        readonly GenericRepository<Star> GenericRepository;
        public StarsController(IRepository<Star> repository)
        {
            this.GenericRepository = (GenericRepository<Star>)repository;
        }

        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Star>>> Get()
        {
            return await GenericRepository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Star>> Get(int id)
        {
            var Star = await GenericRepository.Get(id);
            if (Star == null)
            {
                return NotFound();
            }
            return Star;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Star Star)
        {
            if (id != Star.Id)
            {
                return BadRequest();
            }
            await GenericRepository.Update((Star)Star);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<Star>> Post(Star Star)
        {
            await GenericRepository.Add((Star)Star);
            return CreatedAtAction("Get", new { id = Star.Id }, Star);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Star>> Delete(int id)
        {
            var Star = await GenericRepository.Delete(id);
            if (Star == null)
            {
                return NotFound();
            }
            return Star;
        }
    }
}