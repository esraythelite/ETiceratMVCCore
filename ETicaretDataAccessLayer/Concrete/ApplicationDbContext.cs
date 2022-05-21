using ETicaretEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDataAccessLayer.Concrete
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration = default!;
        protected readonly IServiceCollection ServiceDescriptors = default!;
        public ApplicationDbContext()
        {


        }
        public ApplicationDbContext(IServiceCollection serviceDescriptors)
        {
            ServiceDescriptors = serviceDescriptors;

        }
        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public DbSet<Brand> Brands { get; set; } = default!;
        public DbSet<CargoCompany> CargoCompanies { get; set; } = default!;
        public DbSet<Command> Commands { get; set; } = default!;
        public DbSet<Discount> Discounts { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Password> Passwords { get; set; } = default!;
        public DbSet<Payment> Payments { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = default!;
        public DbSet<ProductPhoto> ProductPhotos { get; set; } = default!;
        public DbSet<ProductProperty> ProductProperties { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<UserDetail> UserDetails { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ETicaretDBConStr"));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().Ignore(a => a.BrandPhoto);
            modelBuilder.Entity<ProductPhoto>().Ignore(a => a.ProdudctImage);
            modelBuilder.Entity<ProductCategory>().Ignore(a => a.CategoryPhoto);
            modelBuilder.Entity<ProductProperty>().Ignore(a => a.ProductColor);
        }
    }
}
