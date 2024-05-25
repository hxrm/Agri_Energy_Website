using Agri_Ene.Data;
using Agri_Ene.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

namespace Agri_Ene.Services
{
    public class AppDbContext : IdentityDbContext<AgriUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// Configure enum property to be saved as string
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.prodCategory)
            //    .HasConversion(new EnumToStringConverter<ProductCategories>());

            var employee = new IdentityRole("employee");
            employee.NormalizedName = "employee";
            var farmer = new IdentityRole("farmer");
            farmer.NormalizedName = "farmer";

            modelBuilder.Entity<IdentityRole>().HasData(employee, farmer);
        }
        public DbSet<Product> Products { get; set; }
    }
}
