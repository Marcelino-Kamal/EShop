using CookiesShop.Data;
using CookiesShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;


namespace CookiesShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;

        public ProductController(ApplicationDbContext context, IHttpClientFactory httpClientFactory)
        {
            _context = context;
            _httpClient = httpClientFactory.CreateClient();
        }
        [HttpPost("AddProduct")]
        public async Task<IActionResult> CreateProduct(Products p) {

            _context.Products.Add(p);
            await _context.SaveChangesAsync();

            return Ok("Product added");      
        }  
        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetAllProduct() {

            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }
        [HttpDelete("DeleteProdtuct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {


            return Ok("Karin has been deleted successfully");
        }
    }
}
