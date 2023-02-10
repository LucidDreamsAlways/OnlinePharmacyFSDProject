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
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            //return await _context.Products.ToListAsync();
            var Products = await _unitOfWork.Products.GetAll();
            return Ok(Products);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var Product = await _unitOfWork.Products.Get(q => q.Id == id);

            if (Product == null)
            {
                return NotFound();
            }

            return Ok(Product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product Product)
        {
            if (id != Product.Id)
            {
                return BadRequest();
            }

            //_context.Entry(Product).State = EntityState.Modified;
            _unitOfWork.Products.Update(Product);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product Product)
        {
            await _unitOfWork.Products.Insert(Product);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProduct", new { id = Product.Id }, Product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var Product = await _unitOfWork.Products.Get(q => q.Id == id);
            if (Product == null)
            {
                return NotFound();
            }

            await _unitOfWork.Products.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ProductExists(int id)
        {
            var Product = await _unitOfWork.Products.Get(q => q.Id == id);
            return Product != null;
            //return _context.Products.Any(e => e.Id == id);
        }
    }
}
