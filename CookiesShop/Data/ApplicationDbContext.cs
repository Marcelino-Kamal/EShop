using CookiesShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CookiesShop.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Orders> Orders { get;set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        
            modelBuilder.Entity<Role>().HasData(
                new Role { id = 1, Name = "Admin" },
                new Role { id = 2, Name = "Customer" }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { id = 1, name = "Cookies"},
                new Category { id = 2, name = "Brownies" },
                new Category { id = 3, name = "Cakes/Minies" },
                new Category { id = 4, name = "Boxes" }
            );
           
        }
    }
}
