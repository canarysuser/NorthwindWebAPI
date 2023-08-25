using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindWebAPI.Models;

namespace NorthwindWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors()]
    public class ProductsController : ControllerBase
    {
        private readonly NorthwindContext context = new ();

        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            var list = context.Products.AsNoTracking().ToList();
            return list;
        }
        //URL: /api/products/details/1
        [HttpGet(template:"details/{productId}")]
        public ActionResult<Product> Get(int productId) {
            var model = context.Products
                .AsNoTracking()
                .SingleOrDefault(c => c.ProductId == productId);
            return model!;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(new { message="Incomplete request. Details missing", errors=ModelState });
            }
            var objExists = await context.Products.FindAsync(product.ProductId); 
            if(objExists == null)
            {
                await context.Products.AddAsync(product);
                await context.SaveChangesAsync();
                return Ok(product);
            } else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, product);
            }
        }
        [HttpPut(template: "{productId}")] //URL: /api/products/10
        public async Task<IActionResult> UpdateProduct(int productId, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { message = "Incomplete request. Details missing", errors = ModelState });
            }
            var objExists = await context.Products
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c=>c.ProductId==product.ProductId);

            if (objExists != null)
            {
                context.Entry(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(product);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, product);
            }
        }
    }
}
