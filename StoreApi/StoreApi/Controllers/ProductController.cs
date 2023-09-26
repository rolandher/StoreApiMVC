using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.DTO;
using StoreApi.Model;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ToDoAPIDbContext dbContext;

        public ProductController(ToDoAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "GetProducts")]
        public async Task<List<Product>> Get()
        {
            return await dbContext.Products.ToListAsync();
        }        

        [HttpPost(Name = "RegisterProduct")]

        public async Task<Product> Post(RegisterProductDTO product)
        {
            var newProduct = new Product();
            newProduct.Name = product.Name;
            newProduct.Description = product.Description;
            newProduct.Price = product.Price;
            newProduct.Stock = product.Stock;
            newProduct.Category = product.Category;

            dbContext.Add(newProduct);
            await dbContext.SaveChangesAsync();
            return newProduct;
        }
    }

}
