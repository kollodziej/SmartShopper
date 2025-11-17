using Microsoft.EntityFrameworkCore;
using SmartShopperDomain.Entities;
using System.Reflection;

namespace SmartShopperInfrastructure
{
    public class SmartShopperContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingList> ShoppingLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
