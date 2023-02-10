using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Server.Data;
using Test.Server.IRepository;
using Test.Shared.Domain;

namespace Test.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExamplesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Examples
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Example>>> GetExamples()
        {
            //return await _context.Examples.ToListAsync();
            var Examples = await _unitOfWork.Examples.GetAll();
            return Ok(Examples);
        }

        // GET: api/Examples/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Example>> GetExample(int id)
        {
            var Example = await _unitOfWork.Examples.Get(q => q.Id == id);

            if (Example == null)
            {
                return NotFound();
            }

            return Ok(Example);
        }

        // PUT: api/Examples/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExample(int id, Example Example)
        {
            if (id != Example.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Example).State = EntityState.Modified;
            _unitOfWork.Examples.Update(Example);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ExampleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Examples
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Example>> PostExample(Example Example)
        {
            await _unitOfWork.Examples.Insert(Example);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetExample", new { id = Example.Id }, Example);
        }

        // DELETE: api/Examples/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExample(int id)
        {
            var Example = await _unitOfWork.Examples.Get(q => q.Id == id);
            if (Example == null)
            {
                return NotFound();
            }

            await _unitOfWork.Examples.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ExampleExists(int id)
        {
            var Example = await _unitOfWork.Examples.Get(q => q.Id == id);
            return Example != null;
            //return _context.Examples.Any(e => e.Id == id);
        }
    }
}
