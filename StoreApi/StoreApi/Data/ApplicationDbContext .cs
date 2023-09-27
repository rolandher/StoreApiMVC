using Microsoft.EntityFrameworkCore;
using StoreApi.Model.BranchEntity;
using StoreApi.Model.ProductEntity;
using StoreApi.Model.UserEntity;

namespace StoreApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Branch> Branch { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
    }
}
