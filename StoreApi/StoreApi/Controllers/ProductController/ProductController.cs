using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.DTO.ProductDTO;
using StoreApi.Model.ProductEntity;

namespace StoreApi.Controllers.ProductController
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _dbContext;

        public ProductController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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

            _dbContext.Add(newProduct);
            await _dbContext.SaveChangesAsync();
            return newProduct;
        }

        [HttpPut]
        [Route("AddStock")]
        public async Task<Product> AddStock(AddStockDTO product)
        {
            var productToUpdate = await _dbContext.Product.FirstOrDefaultAsync(x => x.Id == product.ProductId);
            productToUpdate.Stock += product.Stock;
            await _dbContext.SaveChangesAsync();
            return productToUpdate;
        }

        [HttpPost]
        [Route("RegisterFinalCustomerSale")]

        public async Task<Product> RegisterFinal(RegisterFinalCustomerSaleDTO product)
        {
            var productToUpdate = await _dbContext.Product.FirstOrDefaultAsync(x => x.Id == product.ProductId);
            productToUpdate.Stock -= product.Stock;
            await _dbContext.SaveChangesAsync();
            return productToUpdate;
        }


    }

}
