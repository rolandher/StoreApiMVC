using Microsoft.EntityFrameworkCore;
using StoreApi.Model;

namespace StoreApi.Data
{
    public class ToDoAPIDbContext : DbContext
    {

        public ToDoAPIDbContext(DbContextOptions<ToDoAPIDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Branch> Branches { get; set; }
    }
}
