using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartShopperDomain.ValueObjects;

namespace SmartShopperInfrastructure.TypeConfigurations
{
    internal class ListItemTypeConfiguration : IEntityTypeConfiguration<ListItem>
    {
        public void Configure(EntityTypeBuilder<ListItem> builder)
        {
            builder.ToTable("ListItems", "ShoppingPlanning");
            builder.Property(c => c.Quantity);
            builder.Property(c => c.IsChecked);
            builder.HasOne(c => c.Product).WithMany().HasForeignKey("FK_ProductId");
            builder.HasKey(c => c.Id);
        }
    }
}
