using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alltech.DataAccess.Context;
using Alltech.DataAccess.Models;
using Microsoft.AspNetCore.Cors;


namespace Alltech.Api.Controllers
{

    [Route("api/[controller]")]    
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApiContext _context;
       public ProductsController(ApiContext context)
        {
            _context = context;
          
        }

        // GET: api/Products
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Products>>> GetProductsAsync([FromQuery]ParamsDatatable paramsDatatable)
        {
            //var test = HttpContext.Request.Query;
            //int dataTableOrderColumnIdx = Int32.Parse(HttpContext.Request.Query["order[0][column]"]);
            //string dataTableOrderColumnName = HttpContext.Request.Query["column[" + dataTableOrderColumnIdx + "][data]"].ToString();

            //paramsDatatable.sortName = HttpContext.Request.Query[dataTableOrderColumnName].ToString() ?? "Id_prod";
            //paramsDatatable.sortDir = HttpContext.Request.Query["order[0][dir]"].ToString() ?? "Desc_prod";
            //paramsDatatable.queryString = HttpContext.Request.Query["search[value]"].ToString();

            var result = await _context.Products.ToListAsync();

            var datatable = new DataTableModels<Products>()
            {
                draw = paramsDatatable.draw,
                recordsTotal = this._context.Products.Count(),
                recordsFiltered = this._context.Products.Count(),
                data = result
            };

            return Ok(datatable);
        }


     
        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = await _context.Products.FindAsync(id);

            if (products == null)
            {
                return NotFound();
            }

            return Ok(products);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts([FromRoute] int id, [FromBody] Products products)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != products.Id_prod)
            {
                return BadRequest();
            }

            _context.Entry(products).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(id))
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
        [HttpPost]
        public async Task<IActionResult> PostProducts([FromBody] Products products)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Products.Add(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = products.Id_prod }, products);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _context.Products.Remove(products);
            await _context.SaveChangesAsync();

            return Ok(products);
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id_prod == id);
        }
     
    }
}
