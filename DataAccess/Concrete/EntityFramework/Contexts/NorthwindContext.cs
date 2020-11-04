using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=.; initial catalog=Northwind;integrated security=True;
");
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }


}
