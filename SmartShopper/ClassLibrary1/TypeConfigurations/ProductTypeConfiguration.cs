using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartShopperDomain.Entities;
using SmartShopperDomain.Enums;

namespace SmartShopperInfrastructure.TypeConfigurations
{
    internal class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "ShoppingPlanning");
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name);
            builder.Property(c => c.Category).HasConversion(new EnumToStringConverter<ProductCategory>());
        }
    }
}
