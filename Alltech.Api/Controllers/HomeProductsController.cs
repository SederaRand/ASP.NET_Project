using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alltech.DataAccess.Context;
using Alltech.DataAccess.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Alltech.Api.Wrappers;
using Alltech.Api.Filter;
using Alltech.Api.Interfaces;
using Alltech.Api.Helpers;

namespace Alltech.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeProductsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IUriService uriService;


        public HomeProductsController(ApiContext context, IUriService uriService)
        {
            _context = context;
            this.uriService = uriService;

        }

        // GET: api/HomeProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        [HttpGet("catalogue")]
        public async Task<ActionResult<IEnumerable<Products>>> GetCatalogue([FromQuery] PaginationFilter paginationFilter)
        {
            var route = Request.Path.Value;
            var validFilter = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
            var pagedData = await _context.Products
                            .Skip((validFilter.PageNumber -1) * validFilter.PageSize)
                            .Take(validFilter.PageSize)
                            .ToListAsync();           
            var totalRecords = await _context.Products.CountAsync();
            var pagedReponse = PaginationHelpers.CreatePagedReponse<Products>(pagedData, validFilter, totalRecords, uriService, route);
            return Ok(pagedData);
        }   


        // GET: api/HomeProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProducts(int id)
        {
            var products = await _context.Products.FindAsync(id);

            if (products == null)
            {
                return NotFound();
            }

            return Ok(new Response<Products>(products));
        }

        // PUT: api/HomeProducts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducts(int id, Products products)
        {
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

        // POST: api/HomeProducts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Products>> PostProducts(Products products)
        {
            _context.Products.Add(products);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = products.Id_prod }, products);
        }

        // DELETE: api/HomeProducts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Products>> DeleteProducts(int id)
        {
            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }

            _context.Products.Remove(products);
            await _context.SaveChangesAsync();

            return products;
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id_prod == id);
        }

        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Products>>> Search(string name)            
        {
            IQueryable<Products> query = _context.Products;
            query = query.Where(e => e.Name_prod.Contains(name));
            var products = await query.ToListAsync();

            if (products == null)
            {
                return NotFound();
            }

            return products;
        }



    }
}
